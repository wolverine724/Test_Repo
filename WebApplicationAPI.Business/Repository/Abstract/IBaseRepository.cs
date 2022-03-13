using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace WebApplicationAPI.Business.Repository
{
    public interface IBaseRepository<T> where T : class, new()
    {
        void Add(T entity);
        void Commit();
        void Delete(T entity);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetBy(Expression<Func<T, bool>> predicate);
        T GetSingle(Expression<Func<T, bool>> predicate);
        void Update(T entity);
    }
}