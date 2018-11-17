using System;

namespace Item
{
    public class WithWingsItemDecorator : ItemDecorator
    {
        
        public WithWingsItemDecorator(IItem original) : base(original)
        {
            PriceAdjustment = Random.Next(5, 15); 
        }

        public override float GetPrice()
        {
            return base.GetPrice() + PriceAdjustment;
        }

        public override string GetModification()
        {
            return base.GetModification() +  " with wings";
        }
    }
}