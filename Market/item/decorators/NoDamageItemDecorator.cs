namespace Item
{
    public class NoDamageItemDecorator : ItemDecorator
    {
        
        public NoDamageItemDecorator(IItem original) : base(original)
        {
            PriceAdjustment = Random.Next(5, 20); 
        }
        

        public override float GetPrice()
        {
            return base.GetPrice() + PriceAdjustment;
        }
        
        public override string GetDamage()
        {
            return  base.GetDamage() + "no damage"; 
        }
    }
}