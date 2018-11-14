using System.Collections.Generic;

namespace Market
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
            salesmen.Add("Thomaster194");
            customers.Add("Olav");
            customers.Add("Tord");
        }
        
    }
}