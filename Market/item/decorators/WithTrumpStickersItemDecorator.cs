using System;

namespace Item
{
    public class WithTrumpStickersItemDecorator : ItemDecorator
    {
        
        public WithTrumpStickersItemDecorator(IItem original) : base(original)
        {
            _priceAdjustment = Random.Next(-40, -20); 
        }

        public override string getModification()
        {
            return "with Donald Trump stickers"; 
        }
    }
}