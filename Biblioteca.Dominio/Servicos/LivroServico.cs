
using System.Collections.Generic;
using Biblioteca.Dominio.Entidades;
using Biblioteca.Dominio.Repositorio;

namespace Biblioteca.Dominio.Servicos
{
    public class LivroServico : ILivroRepositorio
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

        public void Save(Livro entity)
        {
            throw new System.NotImplementedException();
        }

        public Livro Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IList<Livro> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Livro entity)
        {
            throw new System.NotImplementedException();
        }
    }
}