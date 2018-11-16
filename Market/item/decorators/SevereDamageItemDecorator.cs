namespace Item
{
    public class SevereDamageItemDecorator : ItemDecorator
    {

        public SevereDamageItemDecorator(IItem original) : base(original)
        {
            _priceAdjustment = Random.Next(-20, -70); 
        }


        public override float getPrice()
        {
            return base.getPrice() + _priceAdjustment;
        }
        
        public override string getDamage()
        {
            return base.getDamage() +  "severe damage"; 
        }
    }
}