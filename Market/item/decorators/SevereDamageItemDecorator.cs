namespace Item
{
    public class SevereDamageItemDecorator : ItemDecorator
    {
        public SevereDamageItemDecorator(IItem original) : base(original)
        {
            priceAdjuster.adjustPriceOf(original, -70, -10);
        }

        public override string getDamage()
        {
            return "severe damage"; 
        }
    }
}