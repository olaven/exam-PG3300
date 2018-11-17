namespace Item
{
    public class MultipleDamageItemDecorator : ItemDecorator
    {
       
        public MultipleDamageItemDecorator(IItem original) : base(original)
        {
            PriceAdjustment = Random.Next(-90, -50); 
        }

        public override float GetPrice()
        {
            return base.GetPrice() + PriceAdjustment;
        }
        
        public override string GetDamage()
        {
            return base.GetDamage() +  "with two huge riper and one bump"; 
        }
    }
}