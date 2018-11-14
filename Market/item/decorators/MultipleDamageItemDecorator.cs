namespace Item
{
    public class MultipleDamageItemDecorator : ItemDecorator
    {
        public MultipleDamageItemDecorator(IItem original) : base(original)
        {
            priceAdjuster.adjustPriceOf(this, -90, -50);
        }

        public override string getDamage()
        {
            return "with two huge riper and one bump"; 
        }
    }
}