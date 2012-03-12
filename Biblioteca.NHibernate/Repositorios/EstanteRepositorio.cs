using Biblioteca.Dominio.Entidades;
using Biblioteca.Dominio.Repositorio;
using Biblioteca.NHibernate.NHibernateHelpers;

namespace Biblioteca.NHibernate.Repositorios
{
    public class EstanteRepositorio : Repositorio<Estante>, IEstanteRepositorio
    {
        public EstanteRepositorio(SessionProvider sessionProvider)
            : base(sessionProvider)
        {
        }
    }
}

