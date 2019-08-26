using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace WS.Sqlsugar
{
    public static class SqlSugarServiceCollectionExtensions
    {
        public static IServiceCollection AddSqlSugarClient<TSugarContext>(this IServiceCollection serviceCollection, Action<IServiceProvider, ConnectionConfig> configAction, ServiceLifetime lifetime = ServiceLifetime.Singleton)
            where TSugarContext : IDbFactory
        {
            serviceCollection.TryAdd(new ServiceDescriptor(typeof(ConnectionConfig), p => ConnectionConfigFactory(p, configAction), lifetime));
            serviceCollection.TryAdd(new ServiceDescriptor(typeof(TSugarContext), typeof(TSugarContext), lifetime));
            return serviceCollection;
        }

        private static ConnectionConfig ConnectionConfigFactory(IServiceProvider applicationServiceProvider, Action<IServiceProvider, ConnectionConfig> configAction)
        {
            var config = new ConnectionConfig();
            configAction.Invoke(applicationServiceProvider, config);
            return config;
        }
    }
}
