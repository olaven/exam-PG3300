namespace Item
{
    public class DecentConditionItemDecorator : ItemDecorator
    {
        
        public DecentConditionItemDecorator(IItem original) : base(original)
        {
            PriceAdjustment = Random.Next(-10, 10); 
        }


        public override float GetPrice()
        {
            return base.GetPrice() + PriceAdjustment;
        }
        public override string GetCondition()
        {
            return base.GetCondition() + "decent condition"; 
        }
    }
}