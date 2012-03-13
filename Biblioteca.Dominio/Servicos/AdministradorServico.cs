using System.Collections.Generic;
using Biblioteca.Dominio.Entidades;
using Biblioteca.Dominio.Repositorio;

namespace Biblioteca.Dominio.Servicos
{
    public interface IAdministradorServico
    {
        void AutoCriarBancoDeDados();
        void InserirDados();
        void InserirLivro(Autor autor, string strLivro, Prateleira prateleira);
        IList<Autor> PesquisarAutores();
        IList<Estante> PesquisarEstantes();
        IList<Livro> PesquisarLivros();
        IList<Prateleira> PesquisarPrateleiras();
        Autor PesquisarAutorPor(int id);
        Prateleira PesquisarPrateleiraPor(int id);
        Estante PesquisarEstantePor(int id);
        void InserirAutor(string strAutor);
        void InserirEstante(string strEstante);
        void InserirPrateleira(string strPrateleira, Estante estante);

    }

    public class AdministradorServico : IAdministradorServico
    {
        private readonly IAutorRepositorio _autorDAO;
        private readonly IBancoDadosCreator _bancoDadosCreator;
        private readonly IEstanteRepositorio _estanteDAO;
        private readonly ILivroRepositorio _livroDAO;
        private readonly IPrateleiraRepositorio _prateleiraDAO;



        public AdministradorServico(IAutorRepositorio autorDAO, ILivroRepositorio livroDAO, IEstanteRepositorio estanteDAO, IPrateleiraRepositorio prateleiraDAO, IBancoDadosCreator bancoDadosCreator)
        {
            _autorDAO = autorDAO;
            _livroDAO = livroDAO;
            _estanteDAO = estanteDAO;
            _prateleiraDAO = prateleiraDAO;
            _bancoDadosCreator = bancoDadosCreator;
        }



        public void AutoCriarBancoDeDados()
        {
            _bancoDadosCreator.AutoCriarBancoDeDados();
        }

        public IList<Autor> PesquisarAutores()
        {
            return _autorDAO.GetAll();
        }

        public IList<Estante> PesquisarEstantes()
        {
            return _estanteDAO.GetAll();
        }

        public IList<Livro> PesquisarLivros()
        {
            return _livroDAO.GetAll();
        }

        public IList<Prateleira> PesquisarPrateleiras()
        {
            return _prateleiraDAO.GetAll();
        }



        public void InserirDados()
        {
            var estante = new Estante();
            estante.Categoria = "Infantil";
            _estanteDAO.Save(estante);

            var prateleira = new Prateleira();
            prateleira.Classe = "Inf001";
            estante.AdicionarPrateleira(prateleira);
            _prateleiraDAO.Save(prateleira);

            prateleira = new Prateleira();
            prateleira.Classe = "Inf002";
            estante.AdicionarPrateleira(prateleira);
            _prateleiraDAO.Save(prateleira);

            estante = new Estante();
            estante.Categoria = "Ação";
            _estanteDAO.Save(estante);

            prateleira = new Prateleira();
            prateleira.Classe = "Act001";
            estante.AdicionarPrateleira(prateleira);
            _prateleiraDAO.Save(prateleira);

            prateleira = new Prateleira();
            prateleira.Classe = "Act002";
            estante.AdicionarPrateleira(prateleira);
            _prateleiraDAO.Save(prateleira);

            var autor = new Autor();
            autor.Nome = "Mario";
            _autorDAO.Save(autor);

            var livro = new Livro();
            //livro.Autor = autor;
            livro.Titulo = "Era uma Vez";
            autor.AdicionarLivros(livro);
            prateleira.AdicionarLivros(livro);
            _livroDAO.Save(livro);

            livro = new Livro();
            //livro.Autor = autor;
            livro.Titulo = "João e Maria";
            autor.AdicionarLivros(livro);
            prateleira.AdicionarLivros(livro);
            _livroDAO.Save(livro);

            autor = new Autor();
            autor.Nome = "Luis";
            _autorDAO.Save(autor);

            livro = new Livro();
            //livro.Autor = autor;
            livro.Titulo = "João e o pé de feijão";
            autor.AdicionarLivros(livro);
            prateleira.AdicionarLivros(livro);
            _livroDAO.Save(livro);

            livro = new Livro();
            //livro.Autor = autor;
            livro.Titulo = "Os três porquinhos";
            autor.AdicionarLivros(livro);
            prateleira.AdicionarLivros(livro);
            _livroDAO.Save(livro);
        }

        public void InserirLivro(Autor autor, string strLivro, Prateleira prateleira)
        {
            var livro = new Livro();
            livro.Titulo = strLivro;

            autor.AdicionarLivros(livro);
            prateleira.AdicionarLivros(livro);
            _livroDAO.Save(livro);
        }

        public void InserirAutor(string strAutor)
        {
            var autor = new Autor();
            autor.Nome = strAutor;
            _autorDAO.Save(autor);
        }

        public void InserirEstante(string strEstante)
        {
            var estante = new Estante();
            estante.Categoria = strEstante;
            _estanteDAO.Save(estante);
        }

        public void InserirPrateleira(string strPrateleira, Estante estante)
        {
            var prateleira = new Prateleira();
            prateleira.Classe = strPrateleira;
            estante.AdicionarPrateleira(prateleira);
            _prateleiraDAO.Save(prateleira);
        }
        
        public Autor PesquisarAutorPor(int id)
        {
            return _autorDAO.Get(id);
        }

        public Prateleira PesquisarPrateleiraPor(int id)
        {
            return _prateleiraDAO.Get(id);
        }

        public Estante PesquisarEstantePor(int id)
        {
            return _estanteDAO.Get(id);
        }
    }
}
