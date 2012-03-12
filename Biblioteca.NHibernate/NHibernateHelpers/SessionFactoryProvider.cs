using System;
using Biblioteca.Dominio.Entidades;
using FluentNHibernate;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Conventions;
using Biblioteca.NHibernate.Convencoes;
using NHibernate;


namespace Biblioteca.NHibernate.NHibernateHelpers
{
    public class SessionFactoryProvider : IDisposable
    {
        private FluentConfiguration _fluentConfiguration;
        private ISessionFactory _sessionFactory;

        public void Dispose()
        {
            if (_sessionFactory != null)
            {
                _sessionFactory.Dispose();
            }
        }

        public ISessionFactory GetSessionFactory()
        {
            if (_sessionFactory == null)
            {
                _fluentConfiguration = Fluently.Configure()
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Autor>())
                    .Database(MsSqlConfiguration.MsSql2008.ShowSql()
                                  .ConnectionString(c => c.FromConnectionStringWithKey("ConnectionString")));
                    
                    //Fluently.Configure()
                    //.Database(MsSqlConfiguration.MsSql2008.ShowSql()
                    //.ConnectionString(c => c.FromConnectionStringWithKey("ConnectionString")))
                    //.Mappings(m => m.AutoMappings.Add(AutoMap.AssemblyOf<Livro>(new AppAutomappingCfg())));

                _sessionFactory = _fluentConfiguration.BuildSessionFactory();
            }

            return _sessionFactory;
        }

        public void AutoCriarBancoDeDados()
        {
            if (_fluentConfiguration != null)
            {
                var sessionSource = new SessionSource(_fluentConfiguration);
                ISession session = sessionSource.CreateSession();
                sessionSource.BuildSchema(session);
            }
        }

        private Action<IConventionFinder> GetConventions()
        {
            return c => c.Add<EnumConvention>();
        }
    }

    public class AppAutomappingCfg : DefaultAutomappingConfiguration
    {
        public override bool ShouldMap(Type type)
        {
            return type.Namespace.StartsWith("Biblioteca.Dominio.Entidades");
        }
    }
}