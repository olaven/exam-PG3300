using System;

namespace Item
{
    public class ModerateDamageItemDecorator : ItemDecorator
    {
        public ModerateDamageItemDecorator(IItem original) : base(original)
        {
            PriceAdjustment = Random.Next(5, 15); 
        }

        public override float GetPrice()
        {
            return base.GetPrice() + PriceAdjustment;
        }
        public override string GetDamage()
        {
            return base.GetDamage() +  "with a small bump";
        }
    }
}