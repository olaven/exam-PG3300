using System;
using System.Threading;
using Item;

namespace People
{
    public class Customer : Person
    {
        public Customer(string name) : base(name)
        {
            Market.Instance.Handler += (sender, eventArgs) => { 
                AttemptBuy(eventArgs);
            };
        }
        
        private void AttemptBuy(EventArgs e)
        {
            new Thread(() =>
            {
                if (Wallet.Balance <= 0)
                {
                    return;
                }
                
                // random reaction time added to customer 
                var reactionTime = new Random().Next(50, 100);
                Thread.Sleep(new Random().Next(reactionTime));
                
                var args = (ItemForSaleEventArgs) e;
                Market.Instance.BuyItem(this, args.Item);
            }).Start(); 
        }
        
    }
}
