namespace Item
{
    public class TerribleConditionItemDecorator : ItemDecorator
    {

        public TerribleConditionItemDecorator(IItem original) : base(original)
        {
            PriceAdjustment = Random.Next(-60, -30); 
        }
        
        public override float GetPrice()
        {
            return base.GetPrice() + PriceAdjustment;
        }

        public override string GetCondition()
        {
            return base.GetCondition() +  "terrible condition"; 
        }
    }
}