using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ZY.EFCore
{
    public interface  IDao<T>
    {
        Task<bool> Add(T entity);

        Task<bool> Delete(T entity);
        
    }
}
