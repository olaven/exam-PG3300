using System;
using System.Linq;
using FleaMarket;
using Item;


namespace FleaMarket
{
    public class Salesman : Person
    {
    
        public Salesman(string name) : base(name)
        {}
        
        public virtual void SellItem()
        {
            if(Items.Count < 1)
                return;
            IItem itemForSale = Items[0];
            Items.Remove(itemForSale);
            Market.Instance.AddItem(itemForSale);
            Console.WriteLine("{0} put up their item for sale: {1}", Name, itemForSale.getInformation());
        }
        
        
        public bool Bargain(float priceOfItem, float customerBalance)
        {
            Console.WriteLine("BARGAIN: " + priceOfItem + " _ " + customerBalance);
            float f = new Random().Next(0, 100);
            f = f / 100;
            return f < customerBalance/priceOfItem;
        }
        
    }

}

