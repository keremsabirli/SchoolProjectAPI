using Microsoft.EntityFrameworkCore;
using SchoolProjectAPI.IRepositories;
using SchoolProjectAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SchoolProjectAPI.Repositories
{
    public class BaseRepository<T> : IRepository<T>
        where T : SharedEntities
    {
        readonly SchoolProjectContext schoolProjectContext;
        protected DbSet<T> Table { get; set; }
        public BaseRepository(SchoolProjectContext context)
        {
            schoolProjectContext = context;
            Table = schoolProjectContext.Set<T>();
        }
        public IQueryable<T> Get()
        {
            return Table;
        }
        public T Get(long id)
        {
            return Table.FirstOrDefault(x => x.Id == id);
        }
        public IQueryable<T> GetByCondition(Expression<Func<T, bool>> predicate)
        {
            return Table.Where(predicate);
        }
        public bool Insert(T entity)
        {
            Table.Add(entity);
            return Save();
        }
        public bool Update(T entity)
        {
            Table.Update(entity);
            return Save();
        }
        public bool Delete(T entity)
        {
            Table.Remove(entity);
            return Save();
        }
        public bool Save()
        {
            try
            {
                schoolProjectContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
