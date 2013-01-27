﻿using System;
using System.Collections.Generic;

namespace PointOfSale.Data.Entities
{
    public class Category : IEntity
    {
        public Guid ID { get; set; }

        public string Name { get; set; }

        public List<Item> Items { get; set; }
    }
}
