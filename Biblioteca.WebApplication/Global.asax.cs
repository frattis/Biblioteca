using System;
using Biblioteca.Dominio.Repositorio;
using Biblioteca.Dominio.Servicos;
using Biblioteca.NHibernate.NHibernateHelpers;
using Biblioteca.NHibernate.Repositorios;
using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace Biblioteca.WebApplication
{
    public class Global : System.Web.HttpApplication
    {
        public static WindsorContainer InicializarContainer()
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


        void Application_Start(object sender, EventArgs e)
        {
           

        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs

        }

        void Session_Start(object sender, EventArgs e)
        {
            // Code that runs when a new session is started

        }

        void Session_End(object sender, EventArgs e)
        {
            // Code that runs when a session ends. 
            // Note: The Session_End event is raised only when the sessionstate mode
            // is set to InProc in the Web.config file. If session mode is set to StateServer 
            // or SQLServer, the event is not raised.

        }

    }
}
