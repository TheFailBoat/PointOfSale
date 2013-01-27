using System;
using System.Collections.Generic;
using System.Linq;

namespace PointOfSale.Data
{
    public class Repository<T> : IRepository<T> where T : IEntity
    {
        public IQueryable<T> Get()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> SaveOrUpdate(params T[] entities)
        {
            throw new NotImplementedException();
        }

        public T SaveOrUpdate(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
