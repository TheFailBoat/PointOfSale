using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointOfSale.Data.Entities
{
    public class Employee : IEntity
    {
        public Guid ID { get; set; }

        public string Name { get; set; }

        public List<Payment> Payments { get; set; }
        public List<Bill> Bills { get; set; }
    }
}
