
using System.Collections.Generic;
using Biblioteca.Dominio.Entidades;
using Biblioteca.Dominio.Repositorio;

namespace Biblioteca.Dominio.Servicos
{
    public class EstanteServico
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
    }
}