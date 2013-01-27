using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using PointOfSale.Entity;

namespace PointOfSale.Logic.Data
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var types = GetType().Assembly.GetExportedTypes().Where(x => typeof(IEntity).IsAssignableFrom(x));

            foreach (var type in types)
            {
                typeof(DbModelBuilder)
                    .GetMethod("Entity")
                    .MakeGenericMethod(type)
                    .Invoke(modelBuilder, new object[] { });
            }
        }
    }
}
