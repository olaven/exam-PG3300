using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Item;
using People;

namespace FleaMarket
{
    /// <summary>
    /// This runs the simulation itself.
    /// Customers and salesmen are created
    /// and trade with each other. 
    /// </summary>
    public class Simulation
    {
        private readonly Random _random;    
        
        private readonly List<Salesman> _salesmen;
        // every customer will listen for new items by themselves, through events 
        private readonly List<Customer> _customers;  
        

        public Simulation()
        {
            _random = new Random();

            _salesmen = PopulateSalesmen();
            _customers = PopulateCustomers(); 
            
        }

        public void Run()
        {
            while (true)
            {
                Thread.Sleep(2000);
                GetRandomSellers().SellItem(); // may be several sellers / composite 
            }
        }

        private Salesman GetRandomSellers()
        {
            var amount = _random.Next(1, 3);

            var index = _random.Next(_salesmen.Count); 
            var salesman = new CompositeSalesman( _salesmen[index]);

            // from 1, as first one is already added through constructor above. 
            for (var i = 1; i < amount; i++)
            {
                var randomSalesman = _salesmen[_random.Next(_salesmen.Count)]; 
                salesman.Add(randomSalesman); 
            }

            return salesman; 
        }

        /// <summary>
        /// Gives between 5 and 8 items to the given persons 
        /// </summary>
        /// <param name="salesmen">Salesmen to give items to</param>
        private void GiveItemsTo(IEnumerable<Salesman> salesmen)
        {
            foreach (var salesman in salesmen)
            {
                
                var amount = _random.Next(5, 8); 
                for (var i = 0; i < amount; i++)
                {
                    var item = ItemFactory.GetRandomItem(salesman);
                    salesman.GetItems().Add(item);
                }
            }
        }
        
        
        #region populating lists 
        private List<Salesman> PopulateSalesmen()
        {
            var salesmen = PopulatePersons(PersonType.Salesman, 2, 4).Cast<Salesman>().ToList();
            // salesmen have to own the items they sell 
            GiveItemsTo(salesmen); 
            
            return salesmen;
        }
        

        private List<Customer> PopulateCustomers()
        {
            List<Person> persons = PopulatePersons(PersonType.Customer, 3, 6);
            return persons.Cast<Customer>().ToList(); 
        }
        
        /// <summary>
        /// Returns a list with the given type of person.
        /// </summary>
        /// <param name="type">
        ///    Type of person 
        /// </param>
        /// <param name="min">
        ///    Minimum amount of people 
        /// </param>
        /// <param name="max">
        ///    Maximum amount or people 
        /// </param>
        /// <returns></returns>
        private List<Person> PopulatePersons(PersonType type, int min, int max)
        {
            
            var amount = _random.Next(min, max);
            var list = new List<Person>(); 

            for (var i = 0; i < amount; i++)
            {
                var person = PersonFactory.GetPerson(type); 
                list.Add(person);
            }

            return list;
        }
        #endregion

    }
}