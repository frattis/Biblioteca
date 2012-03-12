using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca.Dominio.Repositorio;
using Biblioteca.Dominio.Entidades;
using Biblioteca.NHibernate.NHibernateHelpers;
using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace Biblioteca.WebApplication.View.Configuracoes
{
    public partial class InserirDados : System.Web.UI.Page
    {
        private IBancoDadosCreator _bancoDadosCreator;

        public void Inserir()
        {
            var provider = new SessionFactoryProvider();
            var sessionProvider = new SessionProvider(provider);
            var sessaoAtual = sessionProvider.GetCurrentSession();

            var estante = new Dominio.Entidades.Estante();
            sessaoAtual.Save(estante);

            var prateleira = new Prateleira();
            estante.AdicionarPrateleira(prateleira);
            sessaoAtual.Save(prateleira);

            var autor = new Autor();
            autor.Nome = "Mario";
            sessaoAtual.Save(autor);

            var livro = new Livro();
            livro.Autor = autor;
            livro.Titulo = "Era uma Vez";
            prateleira.AdicionarLivros(livro);
            sessaoAtual.Save(livro);

            livro = new Livro();
            livro.Autor = autor;
            livro.Titulo = "João e Maria";
            prateleira.AdicionarLivros(livro);
            sessaoAtual.Save(livro);

            autor = new Autor();
            autor.Nome = "Luis";
            sessaoAtual.Save(autor);

            livro = new Livro();
            livro.Autor = autor;
            livro.Titulo = "João e o pé de feijão";
            prateleira.AdicionarLivros(livro);
            sessaoAtual.Save(livro); 
            
            livro = new Livro();
            livro.Autor = autor;
            livro.Titulo = "Os três porquinhos";
            prateleira.AdicionarLivros(livro);
            sessaoAtual.Save(livro); 

        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["Inserir"] != null)
            {
                var container = InicializarContainer();
                _bancoDadosCreator = container.Resolve<IBancoDadosCreator>();

                _bancoDadosCreator.AutoCriarBancoDeDados();
                Inserir();

                Response.Write("Banco de Dados Criado com Sucesso!!!");
                Response.End();
            }
        }

        private static WindsorContainer InicializarContainer()
        {
            var container = new WindsorContainer();
            container.Register(Component.For<IBancoDadosCreator>().ImplementedBy<BancoDadosCreator>());

            return container;
            
        }

    }
}