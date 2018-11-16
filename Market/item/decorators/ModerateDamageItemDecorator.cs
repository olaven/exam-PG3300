using System;

namespace Item
{
    public class ModerateDamageItemDecorator : ItemDecorator
    {
        public ModerateDamageItemDecorator(IItem original) : base(original)
        {
            _priceAdjustment = Random.Next(5, 15); 
        }


        public override float getPrice()
        {
            return base.getPrice() + _priceAdjustment;
        }
        public override string getDamage()
        {
            return base.getDamage() +  "with a small bump";
        }
    }
}