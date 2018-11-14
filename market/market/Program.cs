using System;

namespace Market
{
    class Program
    {
        static void Main(string[] args)
        {
            Item myItem = new ConcreteItem("myItem", 200, new Person());
            NoDamageItemDecorator damaged = new NoDamageItemDecorator(myItem);

            Console.Write(myItem.getInformation());
            Console.WriteLine(damaged.getInformation());
        }
    }
}