
using System.Collections.Generic;
using Biblioteca.Dominio.Entidades;
using Biblioteca.Dominio.Repositorio;

namespace Biblioteca.Dominio.Servicos
{
    public class AutorServico
    {
        private readonly IAutorRepositorio _repositorio;

        public AutorServico(IAutorRepositorio repositorio)
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