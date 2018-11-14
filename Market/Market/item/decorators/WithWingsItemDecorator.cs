using System;

namespace Market
{
    public class WithWingsItemDecorator : ItemDecorator
    {
        public WithWingsItemDecorator(Item original) : base(original)
        {
            priceAdjuster.adjustPriceOf(original, 5, 15);
        }

        public override string getModification()
        {
            return "with wings"; 
        }
    }
}