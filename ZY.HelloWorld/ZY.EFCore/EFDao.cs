using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ZY.EFCore.Entities;

namespace ZY.EFCore
{
    public class EFDao<T> : IDao<T> where T : class
    {
        private LMSData_1226Context db;
        public EFDao(LMSData_1226Context _db)
        {
            db = _db;
        }

        public async Task<bool> Add(T entity)
        {
            await db.AddAsync(entity);
            return await db.SaveChangesAsync()>0;
        }

        public async Task<bool> Delete(T entity)
        {
            db.Set<T>().Remove(entity);
            return await db.SaveChangesAsync() > 0;
        }
    }
}
