using System;
using Item; 

namespace FleaMarket
{
    static class Program
    {
        private static void Main(string[] args)
        {
            Simulation simulation = new Simulation();
            simulation.Run();
        }
    }
}