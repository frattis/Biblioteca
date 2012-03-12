using Biblioteca.Dominio.Entidades;
using FluentNHibernate.Mapping;

namespace Biblioteca.NHibernate.Mapping
{
    public class PrateleiraMap : ClassMap<Prateleira>
    {
        public PrateleiraMap()
        {
            Id(x => x.Id).Column("Id").GeneratedBy.Native();

            References(x => x.Estante);
            HasMany(x => x.Livros);
        }
    }
}