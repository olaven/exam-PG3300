namespace Item
{
    public class NoDamageItemDecorator : ItemDecorator
    {
        
        public NoDamageItemDecorator(IItem original) : base(original)
        {
            _priceAdjustment = Random.Next(5, 20); 
        }


        public override float getPrice()
        {
            return base.getPrice() + _priceAdjustment;
        }
        
        public override string getDamage()
        {
            return  base.getDamage() + "no damage"; 
        }
    }
}