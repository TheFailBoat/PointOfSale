using System;
using System.Collections.Generic;

namespace PointOfSale.Entity
{
    public class BillItem : IEntity
    {
        public Guid ID { get; set; }

        public Bill Bill { get; set; }
        public Item Item { get; set; }
        public List<ItemModifier> Modifiers { get; set; }

        public decimal OverridePrice { get; set; }
        public int Quantity { get; set; }
    }
}
