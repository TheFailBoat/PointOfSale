using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using PointOfSale.Entity;

namespace PointOfSale.Logic.Data
{
    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly EfDataContext ctx;
        public Repository(EfDataContext ctx)
        {
            this.ctx = ctx;
        }

        public IQueryable<T> Get()
        {
            return ctx.Set<T>();
        }
        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return Get().Where(predicate);
        }

        public T Get(Guid id)
        {
            return Get(x => x.ID == id).SingleOrDefault();
        }

        public IEnumerable<T> SaveOrUpdate(params T[] entities)
        {
            return entities.Select(SaveOrUpdate);
        }

        public T SaveOrUpdate(T entity)
        {
            if (entity.ID == default(Guid))
            {
                ctx.Set<T>().Add(entity);
            }
            else
            {
                if (ctx.Entry(entity).State == EntityState.Detached)
                {
                    ctx.Set<T>().Attach(entity);
                }
                ctx.Entry(entity).State = EntityState.Modified;
            }

            ctx.SaveChanges();

            return entity;
        }

        public void Delete(T entity)
        {
            ctx.Set<T>().Remove(entity);
        }
    }
}
