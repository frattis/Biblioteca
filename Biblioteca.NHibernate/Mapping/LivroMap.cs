using Biblioteca.Dominio.Entidades;
using FluentNHibernate.Mapping;

namespace Biblioteca.NHibernate.Mapping
{
    public class LivroMap : ClassMap<Livro>
    {
        public LivroMap()
        {
            Id(x => x.Id).Column("Id").GeneratedBy.Native();

            Map(x => x.Titulo);

            HasManyToMany(x => x.Autores);
            References(x => x.Prateleira);
        }
    }
}