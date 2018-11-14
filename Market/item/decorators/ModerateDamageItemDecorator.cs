using System;

namespace Item
{
    public class ModerateDamageItemDecorator : ItemDecorator
    {
        public ModerateDamageItemDecorator(IItem original) : base(original)
        {
            priceAdjuster.adjustPriceOf(original, 5, 15);
        }

        public override string getModification()
        {
            return "with a small bump";
        }
    }
}