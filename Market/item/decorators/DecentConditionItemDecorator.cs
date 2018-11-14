namespace Item
{
    public class DecentConditionItemDecorator : ItemDecorator
    {
        public DecentConditionItemDecorator(IItem original) : base(original)
        {
            priceAdjuster.adjustPriceOf(original, -10, 10);
        }

        public override string getCondition()
        {
            return "decent condition"; 
        }
    }
}