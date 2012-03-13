using System;
using Biblioteca.Dominio.Servicos;

namespace Biblioteca.WebApplication.View.Configuracoes
{
    public partial class InserirDadosFormulario : System.Web.UI.Page
    {
        private IAdministradorServico _administradorServico;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["Inserir"] != null)
            {
                CriarContainer();

                var autor = _administradorServico.PesquisarAutorPor(Convert.ToInt32(Request.Form["Autor"]));
                var prateleira = _administradorServico.PesquisarPrateleiraPor(Convert.ToInt32(Request.Form["Prat"]));
                var livro = Request.Form["Livro"].ToString();
                _administradorServico.InserirLivro(autor, livro, prateleira);
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
            DropDownListAutor.DataSource = _administradorServico.PesquisarAutores();
            DropDownListPrateleira.DataSource = _administradorServico.PesquisarPrateleiras();
            DropDownListAutor.DataBind();
            DropDownListPrateleira.DataBind();
        }

        protected void ButtonCriarAutor_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Configuracoes/CriarDados.aspx");
            Response.Write("sucesso");
            Response.End();
        }

        protected void ButtonCriarPrateleira_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Configuracoes/CriarDados.aspx");
            Response.Write("sucesso");
            Response.End();
        }
    }
}