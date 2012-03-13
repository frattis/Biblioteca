using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca.Dominio.Repositorio;
using Biblioteca.Dominio.Entidades;
using Biblioteca.Dominio.Servicos;
using Biblioteca.NHibernate.NHibernateHelpers;
using Biblioteca.NHibernate.Repositorios;
using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace Biblioteca.WebApplication.View.Configuracoes
{
    public partial class InserirDados : System.Web.UI.Page
    {
        private IBancoDadosCreator _bancoDadosCreator;
        private IAdministradorServico _administradorServico;

        public void Inserir()
        {

        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["Inserir"] != null)
            {
                var container = InicializarContainer();
                _bancoDadosCreator = container.Resolve<IBancoDadosCreator>();
                _administradorServico = container.Resolve<IAdministradorServico>();
                
                _bancoDadosCreator.AutoCriarBancoDeDados();
                _administradorServico.InserirDadosTeste();

                Response.Write("Banco de Dados Criado com Sucesso!!!");
                Response.End();
            }
        }

        private static WindsorContainer InicializarContainer()
        {
            var container = new WindsorContainer();
            container.Register(Component.For<IBancoDadosCreator>().ImplementedBy<BancoDadosCreator>());
            container.Register(Component.For<IAdministradorServico>().ImplementedBy<AdministradorServico>());
            container.Register(Component.For<IAutorRepositorio>().ImplementedBy<AutorRepositorio>());
            container.Register(Component.For<ILivroRepositorio>().ImplementedBy<LivroRepositorio>());
            container.Register(Component.For<IEstanteRepositorio>().ImplementedBy<EstanteRepositorio>());
            container.Register(Component.For<IPrateleiraRepositorio>().ImplementedBy<PrateleiraRepositorio>());
            
            var sessionFactoryProvider = new SessionFactoryProvider();
            container.Register(Component.For<SessionProvider>().LifeStyle.Singleton.Instance(new SessionProvider(sessionFactoryProvider)));

            //container.Register(Component.For<IAutorRepositorio>().ImplementedBy<AutorServico>());

            return container;
            
        }

    }
}