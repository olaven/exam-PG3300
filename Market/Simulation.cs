using System;
using System.Collections;
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
        private int _tickCount;
        private int _amountOfItems; 
        
        private readonly List<Salesman> _salesmen;
        // every customer will listen for new items by themselves, through events 
        private readonly List<Customer> _customers;  
        
        /// <summary>
        /// This is a simulation of a market.
        ///
        /// The simulation will run as long as
        /// each item has been given a chance
        /// to be bough (everything is not nessecarily
        /// bought). 
        /// </summary>
        public Simulation()
        {
            _random = new Random();
            
            _tickCount = 0; 
            _amountOfItems = 0;  
            
            _salesmen = PopulateSalesmen();
            _customers = PopulateCustomers(); 
            
        }

        public void Run()
        {
            while (true)
            {
                Thread.Sleep(1000);
                GetRandomSellers().SellItem(); // may be several sellers / composite 

                _tickCount++; 
                if (_tickCount > _amountOfItems)
                {
                    break;
                }
            }

            DisplayEndMessage();
        }

        private static void DisplayEndMessage()
        {
            List<IItem> items = Market.Instance.GetItems();
            if (items.Count <= 0)
            {
                return;
            }
            Console.WriteLine("\n\nItems not sold in the market: ");
            foreach (var item in items)
            {
                Console.WriteLine(item.GetInformation());
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
                    _amountOfItems++; 
                }
            }
        }
        
        
        #region populating lists 
        private List<Salesman> PopulateSalesmen()
        {
            var salesmen = PopulatePersons(PersonType.Salesman, 3, 4).Cast<Salesman>().ToList();
            // salesmen have to own the items they sell 
            GiveItemsTo(salesmen); 
            
            return salesmen;
        }
        

        private List<Customer> PopulateCustomers()
        {
            var persons = PopulatePersons(PersonType.Customer, 3, 6);
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