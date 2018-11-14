namespace Market
{
    public class SevereDamageItemDecorator : ItemDecorator
    {
        public SevereDamageItemDecorator(Item original) : base(original)
        {}

        public override string getDamage()
        {
            return "severe damage"; 
        }
    }
}