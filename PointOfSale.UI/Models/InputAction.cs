using System;

namespace PointOfSale.UI.Models
{
    public abstract class InputAction
    {
        public abstract string Name { get; set; }

        //TODO: decide on parameters
        public abstract void Invoke();
    }

    public class PredicateInputAction : InputAction
    {
        public override string Name { get; set; }
        public Action Predicate { get; set; }

        public override void Invoke()
        {
            Predicate();
        }
    }
}
