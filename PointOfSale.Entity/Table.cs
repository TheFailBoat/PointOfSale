﻿using System;
using System.Collections.Generic;

namespace PointOfSale.Entity
{
    public class Table : IEntity
    {
        public Guid ID { get; set; }

        public string Name { get; set; }

        public List<Bill> Bills { get; set; }
    }
}
