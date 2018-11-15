using System;
using System.Collections.Generic;
using System.Threading;
using Item;

namespace FleaMarket
{
    public class Market
    {
        private static Market _market;
        private List<IItem> _items;
        public EventHandler EventHappening;
        private readonly object staticLock = new object(); 
        private static readonly object padlock = new object();


        private Market()
        {
            //private to prohibit instantiation of market object for other classes.
            _items = new List<IItem>();

        }

        public static Market Instance
        {
            //get { return _market ?? (_market = new Market()); }
            get
            {
                lock (padlock)
                {
                    if (_market == null)
                    {
                        _market = new Market();
                    }

                    return _market;
                }
            }
        }

        public List<IItem> GetItems()
        {
            
            return _items;    
        }

        public void AddItem(IItem item)
        {
            _items.Add(item);
            
            
            
            SomeEvent(EventArgs.Empty);
        }

        protected void SomeEvent(EventArgs e)
        {
            EventHandler handler = EventHappening;
            if (handler != null)
            {
                //gi beskjed til customers at de kan kjøpe?
                handler(this, e);
            }
        }

        public void BuyItem(Customer customer)
        {

            lock (staticLock)
            {
                if (_items.Count != 0)
                {                    
                    IItem item = _items.ToArray()[0];
                    Market.Instance.GetItems().Remove(item);

                    Console.WriteLine(customer.Name +  " bought:");
                    Console.WriteLine(item.getInformation());
                    Console.WriteLine("\n");
                }        }
            }
            
    }
}