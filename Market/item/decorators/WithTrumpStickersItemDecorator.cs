using System;

namespace Item
{
    public class WithTrumpStickersItemDecorator : ItemDecorator
    {
        
        public WithTrumpStickersItemDecorator(IItem original) : base(original)
        {
            PriceAdjustment = Random.Next(-40, -20); 
        }

        
        public override float getPrice()
        {
            return base.getPrice() + PriceAdjustment;
        }
        
        public override string getModification()
        {
            return  base.getModification() + "with Donald Trump stickers"; 
        }
    }
}