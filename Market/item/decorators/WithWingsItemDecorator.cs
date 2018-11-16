using System;

namespace Item
{
    public class WithWingsItemDecorator : ItemDecorator
    {
        
        public WithWingsItemDecorator(IItem original) : base(original)
        {
            _priceAdjustment = Random.Next(5, 15); 
        }

        public override float getPrice()
        {
            return base.getPrice() + _priceAdjustment;
        }

        public override string getModification()
        {
            return base.getModification() +  "with wings"; 
        }
    }
}