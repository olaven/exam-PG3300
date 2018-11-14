namespace Market
{
    public class PerfectConditionItemDecorator : ItemDecorator
    {
        public PerfectConditionItemDecorator(Item original) : base(original)
        {}

        public override string getCondition()
        {
            return "perfect condition"; 
        }
    }
}