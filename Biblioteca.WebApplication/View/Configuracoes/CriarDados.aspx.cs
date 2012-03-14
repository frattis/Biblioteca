using System;
using Biblioteca.Dominio.Servicos;

namespace Biblioteca.WebApplication.View.Configuracoes
{
    public partial class CriarDados : System.Web.UI.Page
    {
        private IAdministradorServico _administradorServico;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["InserirAutor"] != null)
            {
                CriarContainer();

                _administradorServico.InserirAutor(Request.Form["Autor"].ToString());
                Response.Write("sucesso");
                Response.End();
            }

            if (Request["InserirEstante"] != null)
            {
                CriarContainer();

                _administradorServico.InserirEstante(Request.Form["Categoria"].ToString());
                //TODO: fazer com que o drop seja atualizado com esse novo registro.
                Response.Write("sucesso");
                Response.End();
            }

            if (Request["InserirPrateleira"] != null)
            {
                CriarContainer();

                var estante = _administradorServico.PesquisarEstantePor(Convert.ToInt32(Request.Form["Estante"]));
                var prateleira = Request.Form["Classe"].ToString();
                _administradorServico.InserirPrateleira(prateleira, estante);
                Response.Write("sucesso");
                Response.End();
            }
        }

        private void CriarContainer()
        {
            var container = Global.InicializarContainer();
            _administradorServico = container.Resolve<IAdministradorServico>();
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            CriarContainer();
            CarregarDados();
        }

        public void CarregarDados()
        {
            DropDownListEstante.DataSource = _administradorServico.PesquisarEstantes();
            DropDownListEstante.DataBind();
        }

        protected void ButtonVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Configuracoes/InserirDadosFormulario.aspx");
            Response.Write("sucesso");
            Response.End();
        }
    }
}