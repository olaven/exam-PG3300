using System;

namespace Item
{
    public class ModerateDamageItemDecorator : ItemDecorator
    {
        public ModerateDamageItemDecorator(IItem original) : base(original)
        {
            PriceAdjustment = Random.Next(5, 15); 
        }


        public override float getPrice()
        {
            return base.getPrice() + PriceAdjustment;
        }
        public override string getDamage()
        {
            return base.getDamage() +  "with a small bump";
        }
    }
}