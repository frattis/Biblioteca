
using System.Collections.Generic;
using Biblioteca.Dominio.Entidades;
using Biblioteca.Dominio.Repositorio;

namespace Biblioteca.Dominio.Servicos
{
    public class AutorServico : IAutorDAO
    {
        private readonly IAutorDAO _autorDAO;

        public AutorServico(IAutorDAO autorDAO)
        {
            _autorDAO = autorDAO;
        }

        public IList<Autor> PesquisarTodos()
        {
            return _autorDAO.GetAll();
        }

        public Autor Pesquisar(int id)
        {
            return _autorDAO.Get(id);
        }

        public void Save(Autor entity)
        {
            throw new System.NotImplementedException();
        }

        public Autor Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IList<Autor> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Autor entity)
        {
            throw new System.NotImplementedException();
        }
    }
}