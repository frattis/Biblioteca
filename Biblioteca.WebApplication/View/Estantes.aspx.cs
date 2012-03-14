using System;
using System.Linq;
using Biblioteca.Dominio.Servicos;
using Biblioteca.WebApplication.Controllers;

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
            grvAutores.DataSource = _administradorServico.PesquisarAutores();
            grvAutores.DataBind();

            grvEstante.DataSource = _administradorServico.PesquisarEstantes();
            grvEstante.DataBind();

            grvLivros.DataSource = _administradorServico.PesquisarLivros()
                                    .Select(x => new Administrador.LivrosConsultaModelView(x));
            grvLivros.DataBind();

            grvPrateleira.DataSource = _administradorServico.PesquisarPrateleiras()
                                    .Select(x => new Administrador.PratileiraConsultaModelView(x));
            grvPrateleira.DataBind();
        }
    }
}