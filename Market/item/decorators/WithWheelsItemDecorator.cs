using System;

namespace Item
{
    public class WithWheelsItemDecorator : ItemDecorator
    {
        public WithWheelsItemDecorator(IItem original) : base(original)
        {
            PriceAdjustment = Random.Next(30, 70); 
        }

        public override float GetPrice()
        {
            return base.GetPrice() + PriceAdjustment;
        }

        public override string GetModification()
        {
            return  base.GetModification() + " with wheels"; 
        }
    }
}