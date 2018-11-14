namespace Market
{
    public class NoDamageItemDecorator : ItemDecorator
    {
        public NoDamageItemDecorator(Item original) : base(original)
        {
            priceAdjuster.adjustPriceOf(original, 5, 20);
        }

        public override string getDamage()
        {
            return "no damage"; 
        }
    }
}