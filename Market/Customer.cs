using System;
using System.Threading;
using Item;

namespace FleaMarket
{
    public class Customer : Person
    {
        public Customer(string name) : base(name)
        {
            Market.Instance.EventHappening += (sender, eventArgs) => { 
                AttemptBuy(eventArgs);
            };
        }

        public void AttemptBuy(EventArgs e)
        {
            new Thread(() =>
            {
                if (Wallet.Balance <= 0)
                {
                    return;
                }
                //random reaction time added to customer 
                Thread.Sleep(new Random().Next(50, 100));
                
                var args = (ItemForSaleEventArgs) e;
                Market.Instance.BuyItem(this, args.Item);
            }).Start(); 
        }
        
    }
}
