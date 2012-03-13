using Biblioteca.Dominio.Entidades;
using Biblioteca.Dominio.Repositorio;

namespace Biblioteca.Dominio.Servicos
{
    public interface IAdministradorServico
    {
        void AutoCriarBancoDeDados();
        void InserirDadosTeste();
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

        #region IAdministradorServico Members

        public void AutoCriarBancoDeDados()
        {
            _bancoDadosCreator.AutoCriarBancoDeDados();
        }

        public void InserirDadosTeste()
        {
            //var provider = new SessionFactoryProvider();
            //var sessionProvider = new SessionProvider(provider);
            //var sessaoAtual = sessionProvider.GetCurrentSession();

            var estante = new Estante();
            _estanteDAO.Save(estante);

            //var prateleira = new Prateleira();
            //estante.AdicionarPrateleira(prateleira);
            //sessaoAtual.Save(prateleira);

            //var autor = new Autor();
            //autor.Nome = "Mario";
            //sessaoAtual.Save(autor);

            //var livro = new Livro();
            //livro.Autor = autor;
            //livro.Titulo = "Era uma Vez";
            //prateleira.AdicionarLivros(livro);
            //sessaoAtual.Save(livro);

            //livro = new Livro();
            //livro.Autor = autor;
            //livro.Titulo = "João e Maria";
            //prateleira.AdicionarLivros(livro);
            //sessaoAtual.Save(livro);

            //autor = new Autor();
            //autor.Nome = "Luis";
            //sessaoAtual.Save(autor);

            //livro = new Livro();
            //livro.Autor = autor;
            //livro.Titulo = "João e o pé de feijão";
            //prateleira.AdicionarLivros(livro);
            //sessaoAtual.Save(livro);

            //livro = new Livro();
            //livro.Autor = autor;
            //livro.Titulo = "Os três porquinhos";
            //prateleira.AdicionarLivros(livro);
            //sessaoAtual.Save(livro); 
        }

        #endregion
    }
}