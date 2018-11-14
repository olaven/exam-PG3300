namespace Market
{
    public class NoDamageItemDecorator : ItemDecorator
    {
        public NoDamageItemDecorator(Item original) : base(original) 
        {}

        public override string getDamage()
        {
            return "no damage"; 
        }
    }
}