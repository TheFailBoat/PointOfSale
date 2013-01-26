using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.Data.Entities;

namespace PointOfSale.Data
{
    public class EfDataContext : DbContext
    {
        public EfDataContext(DbConnection existingConnection)
            : base(existingConnection, true)
        {
        }
        public EfDataContext()
        {
        }

        public void Detach(object entity)
        {
            ((IObjectContextAdapter)this).ObjectContext.Detach(entity);
        }

        public DbSet<TModel> Table<TModel>() where TModel : class
        {
            return Set<TModel>();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}
