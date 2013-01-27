using Autofac;

namespace PointOfSale.Data
{
    public class DataModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // Register IEntities
            builder.RegisterAssemblyTypes(ThisAssembly).As<IEntity>();

            // Register EfDataContext
            builder.Register(x => new EfDataContext()).AsSelf();

            // Register Repository<T>
            builder.RegisterGeneric(typeof (Repository<>)).As(typeof(IRepository<>));

            // Register DbContext
            builder.Register(x => new DataContext()).AsSelf();
        }
    }
}
