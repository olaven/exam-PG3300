using System;

namespace Item
{
    public class WithWingsItemDecorator : ItemDecorator
    {
        
        public WithWingsItemDecorator(IItem original) : base(original)
        {
            PriceAdjustment = Random.Next(5, 15); 
        }

        public override float getPrice()
        {
            return base.getPrice() + PriceAdjustment;
        }

        public override string getModification()
        {
            return base.getModification() +  "with wings"; 
        }
    }
}