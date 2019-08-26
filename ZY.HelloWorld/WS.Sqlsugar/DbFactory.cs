using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace WS.Sqlsugar
{
    public class DbFactory:IDbFactory
    {
        private readonly ConnectionConfig _config;

        public DbFactory(ConnectionConfig config)
        {
            this._config = config;
        }

        public SqlSugarClient GetDbContext(Action<Exception> onErrorEvent) => GetDbContext(null, null, onErrorEvent);
        public SqlSugarClient GetDbContext(Action<string, SugarParameter[]> onExecutedEvent) => GetDbContext(onExecutedEvent);
        public SqlSugarClient GetDbContext(Func<string, SugarParameter[], KeyValuePair<string, SugarParameter[]>> onExecutingChangeSqlEvent) => GetDbContext(null, onExecutingChangeSqlEvent);
        public SqlSugarClient GetDbContext(Action<string, SugarParameter[]> onExecutedEvent = null, Func<string, SugarParameter[], KeyValuePair<string, SugarParameter[]>> onExecutingChangeSqlEvent = null, Action<Exception> onErrorEvent = null)
        {
            SqlSugarClient db = new SqlSugarClient(_config)
            {
                Aop =
                 {
                    
                 }
            };
            return db;
        }
    }
}
