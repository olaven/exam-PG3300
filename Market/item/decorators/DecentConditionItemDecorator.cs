namespace Item
{
    public class DecentConditionItemDecorator : ItemDecorator
    {
        
        public DecentConditionItemDecorator(IItem original) : base(original)
        {
            _priceAdjustment = Random.Next(-10, 10); 
        }


        public override double getPrice()
        {
            return base.getPrice() + _priceAdjustment;
        }
        public override string getCondition()
        {
            return "decent condition"; 
        }
    }
}