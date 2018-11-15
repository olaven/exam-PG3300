namespace Item
{
    public class PerfectConditionItemDecorator : ItemDecorator
    {

        public PerfectConditionItemDecorator(IItem original) : base(original)
        {
            _priceAdjustment = Random.Next(30, 60); 
        }


        public override double getPrice()
        {
            return base.getPrice() + _priceAdjustment;
        }

        public override string getCondition()
        {
            return "perfect condition"; 
        }
    }
}