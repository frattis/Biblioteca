using Biblioteca.Dominio.Entidades;
using Biblioteca.Dominio.Repositorio;
using Biblioteca.NHibernate.NHibernateHelpers;
using System.Collections.Generic;

namespace Biblioteca.NHibernate.Repositorios
{
    public class LivroRepositorio : Repositorio<Livro>, ILivroRepositorio
    {
        public LivroRepositorio(SessionProvider sessionProvider)
            : base(sessionProvider)
        {
        }
    }
}

