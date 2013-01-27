using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

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
    }
}
