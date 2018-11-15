using System;
using Item; 

namespace FleaMarket
{
    static class Program
    {
        private static void Main(string[] args)
        {
            IItem item1 = ItemFactory.getRandomItem(new Salesman("kjell"), 5);
            Console.WriteLine(item1.getInformation());
            //Simulation simulation = new Simulation();
           // simulation.Run();
        }
    }
}