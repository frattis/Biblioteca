using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca.Dominio.Repositorio;
using Biblioteca.Dominio.Entidades;

namespace Biblioteca.WebApplication.View.Configuracoes
{
    public partial class InserirDados : System.Web.UI.Page
    {
        private readonly IRepositorio<Livro> _repositorioLivro;
        private readonly IRepositorio<Dominio.Entidades.Estante> _repositorioEstante;
        private readonly IRepositorio<Prateleira> _repositorioPrateleira;
        private readonly IRepositorio<Dominio.Entidades.Autor> _repositorioAutor;

        public InserirDados(IRepositorio<Livro> repositorioLivro, IRepositorio<Dominio.Entidades.Estante> repositorioEstante, IRepositorio<Prateleira> repositorioPrateleira, IRepositorio<Dominio.Entidades.Autor> repositorioAutor)
        {
            _repositorioLivro = repositorioLivro;
            _repositorioEstante = repositorioEstante;
            _repositorioPrateleira = repositorioPrateleira;
            _repositorioAutor = repositorioAutor;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //var estante = new Dominio.Entidades.Estante();
            //_repositorioEstante.Save(estante);

            //var prateleira = new Prateleira();
            //prateleira.Estante = estante;
            //_repositorioPrateleira.Save(prateleira);

            //var autor = new Dominio.Entidades.Autor();
            //autor.Nome = "Mario";
            //_repositorioAutor.Save(autor);

            //var livro = new Livro();
            //livro.Autor = autor;
            //livro.Prateleira = prateleira;
            //livro.Titulo = "Era uma Vez";
            //_repositorioLivro.Save(livro);
        }
    }
}