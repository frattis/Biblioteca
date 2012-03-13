using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca.Dominio.Entidades;
using Biblioteca.Dominio.Repositorio;
using Biblioteca.NHibernate.NHibernateHelpers;
using Biblioteca.NHibernate.Repositorios;
using Biblioteca.Dominio.Servicos;
using Biblioteca.WebApplication.Controllers;

namespace Biblioteca.WebApplication.View.Estante
{
    public partial class Estantes : System.Web.UI.Page
    {
        private AdministradorServico _servico = new AdministradorServico();

        public Estantes(AdministradorServico servico)
        {
            _servico = servico;
        }

        public AdministradorServico Servico
        {
            get { return _servico; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarDados();
            _servico.InserirDadosTeste();
        }

        public void CarregarDados()
        {
            var provider = new SessionFactoryProvider();
            var sessionProvider = new SessionProvider(provider);
            var sessaoAtual = sessionProvider.GetCurrentSession();
            grvAutores.DataSource = sessaoAtual.QueryOver<Autor>().List<Autor>();
            grvEstante.DataSource = sessaoAtual.QueryOver<Dominio.Entidades.Estante>().List();
            grvLivros.DataSource = sessaoAtual.QueryOver<Livro>().List();
            grvPrateleira.DataSource = sessaoAtual.QueryOver<Prateleira>().List();
            //var listaLivro = sessaoAtual.QueryOver<Livro>().List().Select(x => x.Autor.Nome);
            //var listaLivro1 = sessaoAtual.QueryOver<Livro>().List().Select(x => x.Prateleira.Id);
            //grvLivros.DataSource = listaLivro;

            grvAutores.DataBind();
            grvEstante.DataBind();
            grvLivros.DataBind();
            grvPrateleira.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            _servico.InserirDadosTeste();
        }
    }
}