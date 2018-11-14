namespace Item
{
    public class PerfectConditionItemDecorator : ItemDecorator
    {
        public PerfectConditionItemDecorator(IItem original) : base(original)
        {
            priceAdjuster.adjustPriceOf(original, 30, 60);
        }

        public override string getCondition()
        {
            return "perfect condition"; 
        }
    }
}