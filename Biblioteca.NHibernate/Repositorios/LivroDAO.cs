using Biblioteca.Dominio.Entidades;
using Biblioteca.Dominio.Repositorio;
using Biblioteca.NHibernate.NHibernateHelpers;
using System.Collections.Generic;

namespace Biblioteca.NHibernate.Repositorios
{
    public class LivroDAO : DAO<Livro>, ILivroDAO
    {
        public LivroDAO(SessionProvider sessionProvider)
            : base(sessionProvider)
        {
        }

        public IList<Livro> PesquisarLivrosPorAutor(int autorId)
        {
            return Session.QueryOver<Livro>()
                .Where(x => x.Autor.Id == autorId).List();
        }
    }
}

