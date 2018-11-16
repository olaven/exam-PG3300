namespace Item
{
    public class TerribleConditionItemDecorator : ItemDecorator
    {

        public TerribleConditionItemDecorator(IItem original) : base(original)
        {
            _priceAdjustment = Random.Next(-60, -30); 
        }
        
        public override float getPrice()
        {
            return base.getPrice() + _priceAdjustment;
        }

        public override string getCondition()
        {
            return base.getCondition() +  "terrible condition"; 
        }
    }
}