using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Biblioteca.Dominio.Repositorio;
using Biblioteca.Dominio.Servicos;

namespace Biblioteca.WebApplication.View.Autor
{
    public partial class Autores : System.Web.UI.Page
    {
        private readonly AutorServico _autor;

        public Autores(AutorServico autor)
        {
            _autor = autor;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            var autorlista = _autor.PesquisarTodos();

            GridView1.DataSource = autorlista.OrderBy(x => x.Nome);

            GridView1.DataBind();
        }
        //private static WindsorContainer InicializarContainer()
        //{
        //    var container = new WindsorContainer();
        //    //container.Register(Component.For<IAutorDAO>().ImplementedBy<AutorServico>());
        //    //container.Register(Component.For<IMeuServicoUtil>().ImplementedBy<MeuServicoUtil>());
        //    //container.Register(Component.For<IMeuRepositorio>().ImplementedBy<MeuRepositorio>());
        //    return container;
        //}
    }
}