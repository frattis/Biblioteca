
using System.Collections.Generic;
using Biblioteca.Dominio.Entidades;
using Biblioteca.Dominio.Repositorio;

namespace Biblioteca.Dominio.Servicos
{
    public class EstanteServico : IEstanteRepositorio
    {
        private readonly IEstanteRepositorio _estanteDAO;
        public  EstanteServico(IEstanteRepositorio estanteDAO)
        {
            _estanteDAO = estanteDAO;
        }

        public IList<Estante> PesquisarTodos()
        {
            return _estanteDAO.GetAll();
        }

        public Estante Pesquisar(int id)
        {
            return _estanteDAO.Get(id);
        }

        public void Save(Estante entity)
        {
            throw new System.NotImplementedException();
        }

        public Estante Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IList<Estante> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Estante entity)
        {
            throw new System.NotImplementedException();
        }
    }
}