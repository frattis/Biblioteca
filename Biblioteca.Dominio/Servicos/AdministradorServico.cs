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
            #region Categoria Infantil
            var estante = new Estante();
            estante.Categoria = "Infantil";
            _estanteDAO.Save(estante);

            var prateleirainf = new Prateleira();
            prateleirainf.Classe = "Inf001";
            estante.AdicionarPrateleira(prateleirainf);
            _prateleiraDAO.Save(prateleirainf);

            prateleirainf = new Prateleira();
            prateleirainf.Classe = "Inf002";
            estante.AdicionarPrateleira(prateleirainf);
            _prateleiraDAO.Save(prateleirainf);

            var autor = new Autor();
            autor.Nome = "Mario";
            _autorDAO.Save(autor);
            var livro = new Livro();

            livro.Titulo = "Era uma Vez";
            autor.AdicionarLivros(livro);
            prateleirainf.AdicionarLivros(livro);
            _livroDAO.Save(livro);

            livro = new Livro();
            livro.Titulo = "João e Maria";
            autor.AdicionarLivros(livro);
            prateleirainf.AdicionarLivros(livro);
            _livroDAO.Save(livro);

            autor = new Autor();
            autor.Nome = "Luis";
            _autorDAO.Save(autor);

            livro = new Livro();
            livro.Titulo = "João e o pé de feijão";
            autor.AdicionarLivros(livro);
            prateleirainf.AdicionarLivros(livro);
            _livroDAO.Save(livro);

            livro = new Livro();
            livro.Titulo = "Os três porquinhos";
            autor.AdicionarLivros(livro);
            prateleirainf.AdicionarLivros(livro);
            _livroDAO.Save(livro);
            #endregion

            #region Categoria Ação
            var estanteact = new Estante();
            estanteact.Categoria = "Ação";
            _estanteDAO.Save(estanteact);

            var prateleiraact = new Prateleira();
            prateleiraact.Classe = "Act001";
            estanteact.AdicionarPrateleira(prateleiraact);
            _prateleiraDAO.Save(prateleiraact);

            prateleiraact = new Prateleira();
            prateleiraact.Classe = "Act002";
            estanteact.AdicionarPrateleira(prateleiraact);
            _prateleiraDAO.Save(prateleiraact);

            var autorAct = new Autor();
            autorAct.Nome = "Marcos";
            _autorDAO.Save(autorAct);

            var livroact = new Livro();
            livroact.Titulo = "Era uma Vez no Mexico";
            autorAct.AdicionarLivros(livroact);
            prateleiraact.AdicionarLivros(livroact);
            _livroDAO.Save(livroact);

            livroact = new Livro();
            livroact.Titulo = "Livro de Ação II";
            autorAct.AdicionarLivros(livroact);
            prateleiraact.AdicionarLivros(livroact);
            _livroDAO.Save(livroact);
            #endregion
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
