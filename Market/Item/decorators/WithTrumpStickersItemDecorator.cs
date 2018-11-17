using System;

namespace Item
{
    public class WithTrumpStickersItemDecorator : ItemDecorator
    {
        
        public WithTrumpStickersItemDecorator(IItem original) : base(original)
        {
            PriceAdjustment = Random.Next(-40, -20); 
        }

        public override float GetPrice()
        {
            return base.GetPrice() + PriceAdjustment;
        }
        
        public override string GetModification()
        {
            return  base.GetModification() + " with Donald Trump stickers"; 
        }
    }
}