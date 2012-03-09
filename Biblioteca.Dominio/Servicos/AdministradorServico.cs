using Biblioteca.Dominio.Repositorio;
using Biblioteca.Dominio.Entidades;

namespace Biblioteca.Dominio.Servicos
{
    public interface IAdministradorServico
    {
        void AutoCriarBancoDeDados();
        Autor PesquisarAutor(int id);
        Autor InserirDadosTeste();
    }

    public class AdministradorServico : IAdministradorServico
    {
        private readonly IAutorDAO _autorDAO;
        private readonly ILivroDAO _livroDAO;
        private readonly IEstanteDAO _estanteDAO;
        private readonly IPrateleiraDAO _prateleiraDAO;
        private readonly IBancoDadosCreator _bancoDadosCreator;

        public AdministradorServico(IAutorDAO autorDAO, ILivroDAO livroDAO, IEstanteDAO estanteDAO,
                                    IPrateleiraDAO prateleiraDAO, IBancoDadosCreator bancoDadosCreator)
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

        public Autor PesquisarAutor(int id)
        {
            return _autorDAO.Get(id);
        }


        public Autor InserirDadosTeste()
        {


            var estante = new Estante();
            _estanteDAO.Save(estante);

            var prateleira = new Prateleira();
            prateleira.Estante = estante;
            _prateleiraDAO.Save(prateleira);

            var autor = new Autor();
            autor.Nome = "Mario";
            _autorDAO.Save(autor);

            var livro = new Livro();
            livro.Autor = autor;
            livro.Prateleira = prateleira;
            livro.Titulo = "Era uma Vez";
            _livroDAO.Save(livro);

            return autor;
        }
    }
}

