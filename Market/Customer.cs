using System;

namespace FleaMarket
{
    public class Customer : Person
    {
        public Customer(string name) : base(name)
        {

        }

        public override void Act()
        {

            Console.WriteLine("Customer acting");
        }
    }
}