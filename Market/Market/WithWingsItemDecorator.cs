using System;

namespace Market
{
    public class WithWingsItemDecorator : ItemDecorator
    {
        public WithWingsItemDecorator(Item original) : base(original)
        {
            Price += new Random().Next(20, 30); 
        }

        public override string getModification()
        {
            return "with wings"; 
        }
    }
}