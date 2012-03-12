using System.Collections.Generic;
using Biblioteca.Dominio.Entidades;
using Biblioteca.Dominio.Repositorio;


namespace Biblioteca.Dominio.Repositorio
{
    public interface IAutorServico
    {
        IList<Autor> PesquisarTodos();
    }
}