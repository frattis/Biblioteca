
using System.Collections.Generic;
using Biblioteca.Dominio.Entidades;
using Biblioteca.Dominio.Repositorio;

namespace Biblioteca.Dominio.Servicos
{
    public class AutorServico : IAutorServico
    {
        private readonly IRepositorio<Autor> _repositorio;

        public AutorServico(IRepositorio<Autor> repositorio)
        {
            _repositorio = repositorio;
        }

        public IList<Autor> PesquisarTodos()
        {
            return _repositorio.GetAll();
        }

        public Autor Pesquisar(int id)
        {
            return _repositorio.Get(id);
        }
    }
}