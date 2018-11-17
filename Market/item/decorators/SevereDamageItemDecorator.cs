namespace Item
{
    public class SevereDamageItemDecorator : ItemDecorator
    {

        public SevereDamageItemDecorator(IItem original) : base(original)
        {
            PriceAdjustment = Random.Next(-20, -70); 
        }


        public override float getPrice()
        {
            return base.getPrice() + PriceAdjustment;
        }
        
        public override string getDamage()
        {
            return base.getDamage() +  " that has severe damage"; 
        }
    }
}