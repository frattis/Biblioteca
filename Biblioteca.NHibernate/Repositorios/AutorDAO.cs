using Biblioteca.Dominio.Entidades;
using Biblioteca.Dominio.Repositorio;
using Biblioteca.NHibernate.NHibernateHelpers;

namespace Biblioteca.NHibernate.Repositorios
{
    public class AutorDAO : DAO<Autor>, IAutorDAO
    {
        public AutorDAO(SessionProvider sessionProvider)
            : base(sessionProvider)
        {
        }
    }
}
