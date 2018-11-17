using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Item;

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
        private readonly int _saleCount;
        
        private readonly List<Salesman> _salesmen; 
        private readonly List<Customer> _customers;  
        

        public Simulation(int saleCount)
        {
            _saleCount = saleCount;
            _random = new Random();

            _salesmen = PopulateSalesmen();
            _customers = PopulateCustomers(); 
            
        }

        public void Run()
        {
            
            new Thread(() =>
            {
                while (true)
                {
                    Thread.Sleep(2000);
                    GetRandomSellers().SellItem(); // may be several sellers / composite 
                }
            }).Start();
        }

        private Salesman GetRandomSellers()
        {
            var amount = _random.Next(1, 3);

            var index = _random.Next(_salesmen.Count); 
            var salesman = new CompositeSalesman( _salesmen[index]);

            // from 1, as first one is already added through constructor above. 
            for (var i = 1; i < amount; i++)
            {
                Salesman randomSalesman = _salesmen[_random.Next(_salesmen.Count)]; 
                salesman.Add(randomSalesman); 
            }

            return salesman; 
        }

        /// <summary>
        /// Gives betwenn 5 and 8 items to the given persons 
        /// </summary>
        /// <param name="persons">Persons to give items to</param>
        private void GiveItemsTo(IEnumerable<Person> persons)
        {
            foreach (var person in persons)
            {
                
                var amount = _random.Next(5, 8); 
                for (var i = 0; i < amount; i++)
                {
                    var item = ItemFactory.GetRandomItem(person, 5);
                    person.GetItems().Add(item);
                }
            }
        }
        
        
        #region populating lists 
        private List<Salesman> PopulateSalesmen()
        {
            var persons = PopulatePersons(PersonType.Salesman, 2, 4);
            // salesmen have to own the items they sell 
            GiveItemsTo(persons); 
            
            return persons.Cast<Salesman>().ToList();
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