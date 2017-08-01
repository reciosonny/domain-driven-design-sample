using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApp.Domain.Persistence {
    public class GenericAdoNetRepository<T> : IGenericRepository<T> where T : class {
        private SampleContext dbContext;

        public GenericAdoNetRepository(SampleContext dbContext) {
            this.dbContext = dbContext;
        }

        public IQueryable<T> Query => throw new NotImplementedException();

        public void Add(T entity) {
            //throw new NotImplementedException();
            //Add ADO.net implementation
        }

        public IQueryable<T> FindAllItems(System.Linq.Expressions.Expression<Func<T, bool>> aggregate) {
            throw new NotImplementedException();
        }

        public T FindItem(int id) {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "") {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAllItems() {
            throw new NotImplementedException();
        }

        public T GetFirstItem() {
            throw new NotImplementedException();
        }

        public T GetItem(System.Linq.Expressions.Expression<Func<T, bool>> expression) {
            throw new NotImplementedException();
        }

        public T GetItem(Func<T, bool> expression) {
            throw new NotImplementedException();
        }

        public T GetItem(int id) {
            throw new NotImplementedException();
        }

        public void Remove(T entity) {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<T> entity) {
            throw new NotImplementedException();
        }

        public void Update(T entity) {
            throw new NotImplementedException();
        }
    }
}