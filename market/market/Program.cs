using System;
using Item; 

namespace Market
{
    static class Program
    {
        private static void Main(string[] args)
        {
            IItem myItem = new ConcreteItem("myItem", 200, new Salesman("name"));
            NoDamageItemDecorator damaged = new NoDamageItemDecorator(myItem);

            Console.Write(myItem.getInformation());
            Console.WriteLine(damaged.getInformation());
            Simulation simulation = new Simulation();
            simulation.Run();
        }
    }
}