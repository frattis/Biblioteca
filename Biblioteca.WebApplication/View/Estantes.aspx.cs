using System;
using Biblioteca.Dominio.Servicos;

namespace Biblioteca.WebApplication.View
{
    public partial class Estantes : System.Web.UI.Page
    {
        private IAdministradorServico _administradorServico;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            var container = Global.InicializarContainer();
            _administradorServico = container.Resolve<IAdministradorServico>();
            CarregarDados();
        }

        public void CarregarDados()
        {
            grvAutores.DataSource =  _administradorServico.PesquisarAutores();
            grvEstante.DataSource = _administradorServico.PesquisarEstantes();
            grvLivros.DataSource = _administradorServico.PesquisarLivros();
            grvPrateleira.DataSource = _administradorServico.PesquisarPrateleiras();

            grvAutores.DataBind();
            grvEstante.DataBind();
            grvLivros.DataBind();
            grvPrateleira.DataBind();
        }
    }
}