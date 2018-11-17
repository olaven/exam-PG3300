namespace Item
{
    public class PerfectConditionItemDecorator : ItemDecorator
    {

        public PerfectConditionItemDecorator(IItem original) : base(original)
        {
            PriceAdjustment = Random.Next(30, 60); 
        }


        public override float getPrice()
        {
            return base.getPrice() + PriceAdjustment;
        }

        public override string getCondition()
        {
            return  base.getCondition() + " in perfect condition"; 
        }
    }
}