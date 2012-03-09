using Biblioteca.Dominio.Entidades;
using Biblioteca.Dominio.Repositorio;
using Biblioteca.NHibernate.NHibernateHelpers;

namespace Biblioteca.NHibernate.Repositorios
{
    public class EstanteDAO : DAO<Estante>, IEstanteDAO
    {
        public EstanteDAO(SessionProvider sessionProvider)
            : base(sessionProvider)
        {
        }
    }
}

