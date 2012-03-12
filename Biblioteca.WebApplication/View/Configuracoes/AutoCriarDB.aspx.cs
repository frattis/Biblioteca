using System;
using Biblioteca.Dominio.Repositorio;
using Biblioteca.Dominio.Entidades;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Biblioteca.NHibernate.NHibernateHelpers;
using Biblioteca.NHibernate;

namespace Biblioteca.WebApplication.View.Configuracoes
{
    public partial class AutoCriarDB : System.Web.UI.Page
    {
        private IBancoDadosCreator _bancoDadosCreator;
        //private readonly IRepositorio<Livro> _repositorio;

        protected void Page_Load(object sender, EventArgs e)
        {
            var container = InicializarContainer();
            _bancoDadosCreator = container.Resolve<IBancoDadosCreator>();
        }

        private static WindsorContainer InicializarContainer()
        {
            var container = new WindsorContainer();
            container.Register(Component.For<IBancoDadosCreator>().ImplementedBy<BancoDadosCreator>());

            return container;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            _bancoDadosCreator.AutoCriarBancoDeDados();
            respostalbl.Visible = true;
            Response.WriteFile("Banco de Dados Criado com Sucesso!!!");
            respostalbl.Text = "Banco de Dados Criado com Sucesso!!!";
        }
    }
}