using System;

namespace Item
{
    public class WithWheelsItemDecorator : ItemDecorator
    {

        public WithWheelsItemDecorator(IItem original) : base(original)
        {
            PriceAdjustment = Random.Next(30, 70); 
        }

        public override float getPrice()
        {
            return base.getPrice() + PriceAdjustment;
        }

        public override string getModification()
        {
            return  base.getModification() + "with wheels"; 
        }
    }
}