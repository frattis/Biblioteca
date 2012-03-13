using System;
using System.Collections.Generic;
using Biblioteca.Dominio.Repositorio;
using Biblioteca.Dominio.Entidades;
using Biblioteca.NHibernate.NHibernateHelpers;
using NHibernate;

namespace Biblioteca.WebApplication.View.Configuracoes
{
    public partial class InserirDadosFormulario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSalvar_Click(object sender, EventArgs e)
        {
            var provider = new SessionFactoryProvider();
            var sessionProvider = new SessionProvider(provider);
            var sessaoAtual = sessionProvider.GetCurrentSession();

            var criteria = sessaoAtual.CreateCriteria(typeof(Prateleira));
            var prateleiras = criteria.List<Prateleira>();
            var prateleira = prateleiras[0];

            var autor = new Autor();
            autor.Nome = txbAutor.Text;
            sessaoAtual.SaveOrUpdate(autor);

            var livro = new Livro();
            livro.Autor = autor;
            livro.Titulo = txbLivro.Text;
            prateleira.AdicionarLivros(livro);
            sessaoAtual.Save(livro);

            ClientScript.RegisterStartupScript(typeof(string), "validate", "<script> alert('salvo com sucesso'); </script>");

            txbAutor.Text = string.Empty;
            txbLivro.Text = string.Empty;
        }

    }
}