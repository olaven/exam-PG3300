namespace Item
{
    public class SevereDamageItemDecorator : ItemDecorator
    {

        public SevereDamageItemDecorator(IItem original) : base(original)
        {
            _priceAdjustment = Random.Next(-20, -70); 
        }


        public override double getPrice()
        {
            return base.getPrice() + _priceAdjustment;
        }
        
        public override string getDamage()
        {
            return "severe damage"; 
        }
    }
}