using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericService <T>
    {
        Task Add(T item);
        Task Update(T item);
        Task<bool> Delete (T item);
        Task<bool> SoftDelete(T item);
        Task<List<T>> GetAll(Expression<Func<T, bool>> where = null, Expression<Func<T, object>>[] includeProperty = null);
        Task<T> Get(Expression<Func<T, bool>> where = null, Expression<Func<T, object>>[] includeProperty = null);



    }
}
