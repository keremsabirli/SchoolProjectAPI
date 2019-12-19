using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SchoolProjectAPI.IRepositories
{
    public interface IRepository<T>
    {
        IQueryable<T> Get();
        IQueryable<T> GetByCondition(Expression<Func<T, bool>> predicate);
        T Get(long id);
        bool Insert(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    }
}
