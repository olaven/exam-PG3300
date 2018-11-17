namespace Item
{
    public class DecentConditionItemDecorator : ItemDecorator
    {
        
        public DecentConditionItemDecorator(IItem original) : base(original)
        {
            PriceAdjustment = Random.Next(-10, 10); 
        }


        public override float getPrice()
        {
            return base.getPrice() + PriceAdjustment;
        }
        public override string getCondition()
        {
            return base.getCondition() + " in decent condition"; 
        }
    }
}