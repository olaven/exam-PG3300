using System;

namespace Item
{
    public class WithWheelsItemDecorator : ItemDecorator
    {
        public WithWheelsItemDecorator(IItem original) : base(original)
        {
            
            priceAdjuster.adjustPriceOf(original, 30, 70);
        }

        public override string getModification()
        {
            return "with wheels"; 
        }
    }
}