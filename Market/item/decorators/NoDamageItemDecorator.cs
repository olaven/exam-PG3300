namespace Item
{
    public class NoDamageItemDecorator : ItemDecorator
    {
        
        public NoDamageItemDecorator(IItem original) : base(original)
        {
            PriceAdjustment = Random.Next(5, 20); 
        }
        

        public override float getPrice()
        {
            return base.getPrice() + PriceAdjustment;
        }
        
        public override string getDamage()
        {
            return  base.getDamage() + " that has no damage"; 
        }
    }
}