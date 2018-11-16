using System;

namespace Item
{
    public class WithWheelsItemDecorator : ItemDecorator
    {

        public WithWheelsItemDecorator(IItem original) : base(original)
        {
            _priceAdjustment = Random.Next(30, 70); 
        }

        public override float getPrice()
        {
            return base.getPrice() + _priceAdjustment;
        }

        public override string getModification()
        {
            return  base.getModification() + "with wheels"; 
        }
    }
}