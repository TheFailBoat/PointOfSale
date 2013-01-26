using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Data
{
    public interface IEntity
    {
        Guid ID { get; set; }

        void BuildModel(DbModelBuilder modelBuilder);
    }
}
