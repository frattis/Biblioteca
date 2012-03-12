using System.Collections.Generic;
using Biblioteca.Dominio.Entidades;
using Biblioteca.Dominio.Repositorio;
using Biblioteca.NHibernate.NHibernateHelpers;
using NHibernate;

namespace Biblioteca.NHibernate.Repositorios
{
    public class AutorRepositorio : Repositorio<Autor>, IAutorRepositorio

    {
        public AutorRepositorio(SessionProvider sessionProvider)
            : base(sessionProvider)
        {
        }
        }
}
