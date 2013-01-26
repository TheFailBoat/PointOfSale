using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Data
{
    public interface IRepository<T> : IRepository where T : IEntity
    {
        IQueryable<T> Get();
        IQueryable<T> Get(Expression<Func<T, bool>> predicate);
        T Get(Guid id);
        IEnumerable<T> SaveOrUpdate(params T[] entities);
        T SaveOrUpdate(T entity);
        void Delete(T entity);
    }

    public interface IRepository
    {
    }
}
