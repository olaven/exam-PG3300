namespace Item
{
    public class SevereDamageItemDecorator : ItemDecorator
    {

        public SevereDamageItemDecorator(IItem original) : base(original)
        {
            PriceAdjustment = Random.Next(-20, -70); 
        }

        public override float GetPrice()
        {
            return base.GetPrice() + PriceAdjustment;
        }
        
        public override string GetDamage()
        {
            return base.GetDamage() +  " severe damage"; 
        }
    }
}