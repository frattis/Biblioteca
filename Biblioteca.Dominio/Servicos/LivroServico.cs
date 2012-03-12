
using System.Collections.Generic;
using Biblioteca.Dominio.Entidades;
using Biblioteca.Dominio.Repositorio;

namespace Biblioteca.Dominio.Servicos
{
    public class LivroServico
    {
        private readonly ILivroRepositorio _livroDAO;
        public LivroServico(ILivroRepositorio livroDAO)
        {
            _livroDAO = livroDAO;
        }

        public IList<Livro> PesquisarTodos()
        {
            return _livroDAO.GetAll();
        }

        public Livro Pesquisar(int id)
        {
            return _livroDAO.Get(id);
        }
    }
}