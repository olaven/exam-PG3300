using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Item;

namespace FleaMarket
{
    public class Simulation
    {

        private readonly List<Salesman> _salesmen = new List<Salesman>();
        private readonly List<Customer> _customers = new List<Customer>();
        private readonly Random _random;
        private readonly ArrayList _names = new ArrayList{"Petter", "Kjell", "Kari", "Nils", "Dormammu", "Hank", "Thomaster"};
        private readonly int _saleCount;

        public Simulation(int saleCount)
        {
            _saleCount = saleCount;
            _random = new Random();
            _salesmen.Add(new Salesman(GetRandomName()));
            _salesmen.Add(new Salesman(GetRandomName()));
            _customers.Add(new Customer(GetRandomName()));
            _customers.Add(new Customer(GetRandomName()));
            _customers.Add(new Customer(GetRandomName()));
            _customers.Add(new Customer(GetRandomName()));

            var x = _saleCount / _salesmen.Count;
            foreach(var salesman in _salesmen)
            {
                for (var y = 0; y < x; y++)
                {
                    salesman.AddItem(ItemFactory.GetRandomItem(salesman, 5));
                }
            }
        }

        public void Run()
        {
            while (true)
            {
                Thread.Sleep(2000);
                Salesman seller = _salesmen.ToArray()[_random.Next(0, _salesmen.Count())];
                seller.Act();
                
                Customer customer  = _customers.ToArray()[_random.Next(0, _customers.Count())];
                customer.Act();


            }
            
        }

        private string GetRandomName(){
        if (_names.Count < 1)
        {
            return "John Doe";
        }
        var r = _random.Next(0, _names.Count);
        string name = (string) _names[r];
        _names.RemoveAt(r);
        return name;
    }
    
    
    }
    
 
}