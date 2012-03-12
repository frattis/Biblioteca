using Biblioteca.Dominio.Entidades;
using FluentNHibernate.Mapping;

namespace Biblioteca.NHibernate.Mapping
{
    public class AutorMap : ClassMap<Autor>
    {
        public AutorMap()
        {
            Id(x => x.Id).Column("Id").GeneratedBy.Native();

            Map(x => x.Nome);

            HasMany(x => x.Livros);
        }
    }
}