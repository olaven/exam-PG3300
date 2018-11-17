using System;
using System.Collections.Generic;
using System.Threading;
using Item;

namespace FleaMarket
{
    /// <summary>
    /// This is the market people trade on.
    /// The market is a singleton, as we want
    /// to guarantee that everyone is using
    /// the same market-instance. 
    /// </summary>
    public class Market
    {
        private static Market _market;
        private readonly List<IItem> _items;
        public EventHandler Handler;
        
        private readonly object _staticLock = new object(); 
        private static readonly object Padlock = new object();

        //private to prohibit instantiation of market object for other classes.
        private Market()
        {
            _items = new List<IItem>();

        }
        
        public static Market Instance
        {
            /*
                 * The market could be "null twice" (race condition)
                 * in separate threads.
                 * This would destroy the singletons purpose. Thus a
                 * lock is needed. 
                 */
            get
            {
                lock (Padlock)
                {
                    return _market ?? (_market = new Market());
                }
            }
        }

        public void AddItem(IItem item)
        {
            lock (_staticLock)
            {
                _items.Add(item);
            }

            ItemForSaleEvent(new ItemForSaleEventArgs(item));
        }

        private void ItemForSaleEvent(EventArgs e)
        {
            var handler = Handler;

            //Notify customers that none item is available
            handler?.Invoke(this, e); // "?.Invoke -> if handler != null, run it 
        }

        public void BuyItem(Customer customer, IItem item)
        {

            lock (_staticLock)
            {
                if (_items.Count == 0 || !_items.Contains(item)) return;
                
                var customerBalance = customer.Wallet.Balance;
                var salesman = (Salesman) item.Owner;
                var priceOfItem = item.GetPrice();

                if (customer.Wallet >= priceOfItem || salesman.Haggle(priceOfItem, customerBalance))
                {
                    DoTransaction(customer, salesman, item, false);
                } else if (salesman.Haggle(priceOfItem, customerBalance))
                {
                    DoTransaction(customer, salesman, item, true);
                }
            }
        }

        private void DoTransaction(Customer customer, Salesman seller, IItem item, bool isBargain)
        {
            // removed from market 
            _items.Remove(item);
            
            // if this was a bargain, the price is reduced to the money customer can pay 
            var realCost = (isBargain ? customer.Wallet.Balance : item.GetPrice());
            
            //transfer money back and forth
            customer.Wallet.Balance -= realCost; 
            seller.Wallet.Balance += realCost;
            
            item.Owner = customer;
            customer.GetItems().Add(item);

            Console.WriteLine("{0, 50} bought {1} {2}", customer.Name, item.GetInformation(), customer.Image);
        }
    }
}