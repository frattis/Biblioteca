using System;
using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.AcceptanceCriteria;
using FluentNHibernate.Conventions.Inspections;
using FluentNHibernate.Conventions.Instances;

namespace Biblioteca.NHibernate.Convencoes
{
    public class EnumConvention : IUserTypeConvention
    {
        #region IUserTypeConvention Members

        public void Accept(IAcceptanceCriteria<IPropertyInspector> criteria)
        {
            criteria.Expect(x => x.Property.PropertyType.IsEnum ||
                                 (x.Property.PropertyType.IsGenericType &&
                                  x.Property.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) &&
                                  x.Property.PropertyType.GetGenericArguments()[0].IsEnum)
                );
        }

        public void Apply(IPropertyInstance target)
        {
            target.CustomType(target.Property.PropertyType);
        }

        #endregion
    }
}