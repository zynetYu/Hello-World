using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace WS.Sqlsugar
{
    public class Repository<TFactory, TIRepository> : IRepository where TFactory : IDbFactory where TIRepository : IRepository
    {
        protected readonly TFactory Factory;
        protected readonly TIRepository DbRepository;
        protected SqlSugarClient DbContext => this.Factory.GetDbContext();

        public Repository(TFactory factory) => Factory = factory;
        public Repository(TFactory factory, TIRepository repository) : this(factory) => DbRepository = repository;
    }

    public class Repository<TFactory> : IRepository where TFactory : IDbFactory
    {
        protected readonly TFactory Factory;
        protected SqlSugarClient DbContext => this.Factory.GetDbContext();

        public Repository(TFactory factory) => Factory = factory;
    }
}
