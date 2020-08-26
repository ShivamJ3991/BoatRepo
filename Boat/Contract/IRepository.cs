using Boat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Boat.Contract
{
    public interface IRepository<T> where T : BaseModel
    {
        IEnumerable<T> GetAll();
        T Get(long id);
        T Insert(T entity);
        T Update(T entity);
        void Delete(T entity);
        //IQueryable<T> Query { get; }
        IQueryable<T> Where(Expression<Func<T, bool>> predicate);
    }
}
