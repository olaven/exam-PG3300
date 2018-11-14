using System.Collections.Generic;

namespace FleaMarket
{
    public class Simulation
    {

        private List<Salesman> salesmen = new List<Salesman>();
        private List<Customer> customers = new List<Customer>();

        public Simulation()
        {
            Run();
        }

        public void Run()
        {
            salesmen.Add(new Salesman("Thomaster194"));
            customers.Add(new Customer("Olav"));
            customers.Add(new Customer("Tord"));
        }
        
    }
}