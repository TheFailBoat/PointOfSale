using System;
using System.Collections.Generic;

namespace PointOfSale.Data.Entities
{
    public class Bill : IEntity
    {
        public Guid ID { get; set; }

        public DateTime OpenDate { get; set; }
        public DateTime? CloseDate { get; set; }

        // Possibly multiple in future
        public Table Table { get; set; }

        public Employee CreatedBy { get; set; }

        public List<BillItem> Items { get; set; }
        public List<Payment> Payments { get; set; }
    }
}
