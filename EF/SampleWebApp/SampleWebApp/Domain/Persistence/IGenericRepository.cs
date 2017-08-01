using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SampleWebApp.Domain.Persistence {
    public interface IGenericRepository<T> where T : class {
        IQueryable<T> Query { get; }

        void Add(T entity);
        IQueryable<T> FindAllItems(Expression<Func<T, bool>> aggregate);
        IEnumerable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");
        T GetFirstItem();
        T GetItem(Expression<Func<T, bool>> expression);
        T GetItem(Func<T, bool> expression);
        T GetItem(int id);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
        void Update(T entity);
        T FindItem(int id);
        IEnumerable<T> GetAllItems();
    }
}