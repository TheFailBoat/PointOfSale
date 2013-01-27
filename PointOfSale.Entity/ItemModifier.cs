using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Entity
{
    public class ItemModifier : IEntity
    {
        public Guid ID { get; set; }

        //TODO: 1 = X, 2 = Y, 3 = ...
        public int Type { get; set; }

        public string Name { get; set; }
        public decimal PriceDifference { get; set; }
    }
}
