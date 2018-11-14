namespace Market
{
    public class PerfectConditionItemDecorator : ItemDecorator
    {
        public PerfectConditionItemDecorator(Item original) : base(original)
        {
            priceAdjuster.adjustPriceOf(original, 30, 60);
        }

        public override string getCondition()
        {
            return "perfect condition"; 
        }
    }
}