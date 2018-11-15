namespace Item
{
    public class MultipleDamageItemDecorator : ItemDecorator
    {
       
        public MultipleDamageItemDecorator(IItem original) : base(original)
        {
            _priceAdjustment = Random.Next(-90, -50); 
        }


        public override double getPrice()
        {
            return base.getPrice() + _priceAdjustment;
        }
        
        public override string getDamage()
        {
            return base.getDamage() +  "with two huge riper and one bump"; 
        }
    }
}