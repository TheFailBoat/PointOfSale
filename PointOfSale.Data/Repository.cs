using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Data
{
    public class Repository<T> : IRepository<T>
    {

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> SaveOrUpdateAll(params T[] entities)
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
