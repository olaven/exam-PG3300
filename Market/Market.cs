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
            

            
            
            ItemForSaleEvent(new ItemForSaleEventArgs(item));
        }

        protected void ItemForSaleEvent(EventArgs e)
        {
            EventHandler handler = EventHappening;
            if (handler != null)
            {
                //gi beskjed til customers at de kan kjøpe
                handler(this, e);
            }
        }

        public void BuyItem(Customer customer, IItem item)
        {

            lock (staticLock)
            {
                if (_items.Count != 0 && _items.Contains(item))
                {
                    var customerBalance = customer.Wallet.Balance;
                    var seller = (Salesman) item.Owner;
                    var itemPrice = item.getPrice();
                    
                    if (customerBalance >= itemPrice)
                    {
                        _items.Remove(item);
                        customer.Wallet.Balance -= itemPrice;
                        seller.Wallet.Balance += itemPrice;
                        item.Owner = customer;
                       
                        Console.WriteLine("{0, 50} bought {1}", customer.Name, item.getInformation());
                    }
                    else
                    {
                        Console.WriteLine("{0} asks for bargain offers {1} for item with price {2}", customer.Name, customerBalance, itemPrice);
                        //customer asks for bargain
                        if (seller.Bargain(itemPrice, customerBalance))
                        {
                            Console.WriteLine("Bargain accepted");
                        }
                        
                    }
              
                }
                else
                {
                   // Console.WriteLine(customer.Name + " attempted to buy but was too slow");
                }      
            }
        }
            
    }
}