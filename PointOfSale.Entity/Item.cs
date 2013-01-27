using System;
using System.Collections.Generic;

namespace PointOfSale.Entity
{
    public class Item : IEntity
    {
        public Guid ID { get; set; }

        public string Name { get; set; }
        public decimal Price { get; set; }

        public Category Category { get; set; }
        public List<ItemModifier> Modifiers { get; set; }
    }
}
