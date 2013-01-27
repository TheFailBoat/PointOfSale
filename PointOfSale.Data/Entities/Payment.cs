using System;

namespace PointOfSale.Data.Entities
{
    public class Payment : IEntity
    {
        public Guid ID { get; set; }

        //TODO: 1 = X, 2 = Y, 3 = ...
        public int Method { get; set; }
        public decimal Amount { get; set; }

        public Bill Bill { get; set; }

        public DateTime TakenAt { get; set; }
        public Employee TakenBy { get; set; }

    }
}
