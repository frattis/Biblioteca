using System;
using System.Linq;
using Biblioteca.Dominio.Servicos;
using Biblioteca.Dominio.Repositorio;
using Biblioteca.Dominio.Entidades;
using Biblioteca.NHibernate.Repositorios;
using Biblioteca.NHibernate;
using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace Biblioteca.WebApplication.View.Autores
{
    public partial class Autores : System.Web.UI.Page
    {
        //private IAutorServico _autorServico;

        //public Autores(IAutorServico autorServico)
        //{
        //    _autorServico = autorServico;
        //}

        protected void Page_Load(object sender, EventArgs e)
        {
            //            var container = InicializarContainer();
            //            _autorServico = container.Resolve<IAutorServico>();

            //var autorlista = _autorServico.PesquisarTodos();

            //GridView1.DataSource = autorlista.OrderBy(x => x.Nome);

            //GridView1.DataBind();
        }

        private static WindsorContainer InicializarContainer()
        {
            var container = new WindsorContainer();
            container.Register(Component.For<IAutorServico>().ImplementedBy<AutorServico>());
            container.Register(Component.For<IRepositorio<Autor>>().ImplementedBy<Repositorio<Autor>>());
            return container;
        }
    }
}

