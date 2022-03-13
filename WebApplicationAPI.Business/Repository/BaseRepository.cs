using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using WebApplicationAPI.Data.Data;

namespace WebApplicationAPI.Business.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, new()
    {
        private FairyDustContext _fairyDustContext;
        public BaseRepository(FairyDustContext fairyDustContext)
        {
            _fairyDustContext = fairyDustContext;
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _fairyDustContext.Set<T>().ToList();
        }

        public virtual T GetSingle(Expression<Func<T, bool>> predicate)
        {
            return _fairyDustContext.Set<T>().FirstOrDefault(predicate);
        }

        public virtual IEnumerable<T> GetBy(Expression<Func<T, bool>> predicate)
        {
            return _fairyDustContext.Set<T>().Where(predicate);
        }

        public virtual void Add(T entity)
        {
            _fairyDustContext.Add(entity);
        }

        public virtual void Update(T entity)
        {
            EntityEntry entityEntry = _fairyDustContext.Entry<T>(entity);
            entityEntry.State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            EntityEntry entityEntry = _fairyDustContext.Entry<T>(entity);
            entityEntry.State = EntityState.Deleted;
        }

        public virtual void Commit()
        {
            _fairyDustContext.SaveChanges();
        }
    }
}
