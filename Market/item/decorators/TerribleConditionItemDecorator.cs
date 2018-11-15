namespace Item
{
    public class TerribleConditionItemDecorator : ItemDecorator
    {

        public TerribleConditionItemDecorator(IItem original) : base(original)
        {
            _priceAdjustment = Random.Next(-60, -30); 
        }

        public override string getCondition()
        {
            return base.getCondition() +  "terrible condition"; 
        }
    }
}