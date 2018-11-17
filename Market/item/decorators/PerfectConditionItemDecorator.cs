namespace Item
{
    public class PerfectConditionItemDecorator : ItemDecorator
    {

        public PerfectConditionItemDecorator(IItem original) : base(original)
        {
            PriceAdjustment = Random.Next(30, 60); 
        }

        public override float GetPrice()
        {
            return base.GetPrice() + PriceAdjustment;
        }

        public override string GetCondition()
        {
            return  base.GetCondition() + " in perfect condition"; 
        }
    }
}