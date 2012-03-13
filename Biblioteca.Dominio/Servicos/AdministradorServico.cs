using Biblioteca.Dominio.Repositorio;
using Biblioteca.Dominio.Entidades;

namespace Biblioteca.Dominio.Servicos
{
    public interface IAdministradorServico
    {

    }

    public class AdministradorServico : IAdministradorServico
    {
        private readonly IAutorRepositorio _autorDAO;
        private readonly ILivroRepositorio _livroDAO;
        private readonly IEstanteRepositorio _estanteDAO;
        private readonly IPrateleiraRepositorio _prateleiraDAO;
        private readonly IBancoDadosCreator _bancoDadosCreator;

        public AdministradorServico(IAutorRepositorio autorDAO, ILivroRepositorio livroDAO, IEstanteRepositorio estanteDAO,
                                    IPrateleiraRepositorio prateleiraDAO, IBancoDadosCreator bancoDadosCreator)
        {
            _autorDAO = autorDAO;
            _livroDAO = livroDAO;
            _estanteDAO = estanteDAO;
            _prateleiraDAO = prateleiraDAO;
            _bancoDadosCreator = bancoDadosCreator;
        }

        public AdministradorServico()
        {
         
        }


        public void AutoCriarBancoDeDados()
        {
            _bancoDadosCreator.AutoCriarBancoDeDados();
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

