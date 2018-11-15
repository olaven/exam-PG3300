using System;

namespace Item
{
    public class ModerateDamageItemDecorator : ItemDecorator
    {
        public ModerateDamageItemDecorator(IItem original) : base(original)
        {
            _priceAdjustment = Random.Next(5, 15); 
        }


        public override double getPrice()
        {
            return base.getPrice() + _priceAdjustment;
        }
        public override string getModification()
        {
            return "with a small bump";
        }
    }
}