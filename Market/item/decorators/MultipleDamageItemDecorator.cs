namespace Item
{
    public class MultipleDamageItemDecorator : ItemDecorator
    {
       
        public MultipleDamageItemDecorator(IItem original) : base(original)
        {
            PriceAdjustment = Random.Next(-90, -50); 
        }


        public override float getPrice()
        {
            return base.getPrice() + PriceAdjustment;
        }
        
        public override string getDamage()
        {
            return base.getDamage() +  " with two huge scratches and one bump"; 
        }
    }
}