using Biblioteca.Dominio.Entidades;
using FluentNHibernate.Mapping;

namespace Biblioteca.NHibernate.Mapping
{
    public class EstanteMap : ClassMap<Estante>
    {
        public EstanteMap()
        {
            Id(x => x.Id).Column("Id").GeneratedBy.Native();
            Map(x => x.Categoria);

            HasMany(x => x.Prateleiras);
        }
    }
}
