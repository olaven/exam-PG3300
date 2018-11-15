namespace Item
{
    public class TerribleConditionItemDecorator : ItemDecorator
    {
        public TerribleConditionItemDecorator(IItem original) : base(original)
        {
            priceAdjuster.adjustPriceOf(original, -60, -30);
        }

        public override string getCondition()
        {
            return "terrible condition"; 
        }
    }
}