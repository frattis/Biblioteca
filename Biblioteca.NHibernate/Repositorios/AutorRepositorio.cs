using Biblioteca.Dominio.Entidades;
using Biblioteca.Dominio.Repositorio;
using Biblioteca.NHibernate.NHibernateHelpers;

namespace Biblioteca.NHibernate.Repositorios
{
    public class AutorRepositorio : IAutorRepositorio

    {
        private readonly SessionProvider _sessionProvider;

        public AutorRepositorio(SessionProvider sessionProvider) : base(sessionProvider)
        {
            _sessionProvider = sessionProvider;
        }
    }
}
