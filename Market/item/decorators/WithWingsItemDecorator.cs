using System;

namespace Item
{
    public class WithWingsItemDecorator : ItemDecorator
    {
        public WithWingsItemDecorator(IItem original) : base(original)
        {
            priceAdjuster.adjustPriceOf(original, 5, 15);
        }

        public override string getModification()
        {
            return "with wings"; 
        }
    }
}