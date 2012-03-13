using System;
using Biblioteca.Dominio.Servicos;

namespace Biblioteca.WebApplication.View.Configuracoes
{
    public partial class InserirDados : System.Web.UI.Page
    {
       private IAdministradorServico _administradorServico;

        public void Inserir()
        {

        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["Inserir"] != null)
            {
                var container = Global.InicializarContainer();
                _administradorServico = container.Resolve<IAdministradorServico>();

                _administradorServico.AutoCriarBancoDeDados();
                _administradorServico.InserirDados();
                Response.Write("sucesso");
                Response.End();
            }
        }

    }
}