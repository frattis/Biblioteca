using System;
using Biblioteca.Dominio.Repositorio;
using Biblioteca.Dominio.Servicos;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Biblioteca.NHibernate.NHibernateHelpers;
using Biblioteca.NHibernate;

namespace Biblioteca.WebApplication.View.Configuracoes
{
    public partial class AutoCriarDB : System.Web.UI.Page
    {
        private IAdministradorServico _administradorServico;


        protected void Page_Load(object sender, EventArgs e)
        {
            var container = InicializarContainer();
            _administradorServico = container.Resolve<IAdministradorServico>();
        }

        private static WindsorContainer InicializarContainer()
        {
            var container = new WindsorContainer();
            container.Register(Component.For<IRepositorio<AutorServico>>().ImplementedBy<DAO<AutorServico>>());
            container.Register(Component.For<IAdministradorServico>().ImplementedBy<AdministradorServico>());
            container.Register(Component.For<IRepositorio<LivroServico>>().ImplementedBy<DAO<LivroServico>>());
            container.Register(Component.For<IRepositorio<EstanteServico>>().ImplementedBy<DAO<EstanteServico>>());
            container.Register(Component.For<IRepositorio<PrateleiraServico>>().ImplementedBy<DAO<PrateleiraServico>>());
            container.Register(Component.For<IAutorDAO>().ImplementedBy<AutorServico>());
            container.Register(Component.For<IEstanteDAO>().ImplementedBy<EstanteServico>());
            container.Register(Component.For<IPrateleiraDAO>().ImplementedBy<PrateleiraServico>());
            container.Register(Component.For<ILivroDAO>().ImplementedBy<LivroServico>());
            container.Register(Component.For<IBancoDadosCreator>().ImplementedBy<BancoDadosCreator>());

            
            return container;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            _administradorServico.AutoCriarBancoDeDados();
        }
    }
}