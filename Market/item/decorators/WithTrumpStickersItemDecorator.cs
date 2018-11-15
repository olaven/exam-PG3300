using System;

namespace Item
{
    public class WithTrumpStickersItemDecorator : ItemDecorator
    {
        
        public WithTrumpStickersItemDecorator(IItem original) : base(original)
        {
            _priceAdjustment = Random.Next(-40, -20); 
        }

        
        public override double getPrice()
        {
            return base.getPrice() + _priceAdjustment;
        }
        
        public override string getModification()
        {
            return  base.getModification() + "with Donald Trump stickers"; 
        }
    }
}