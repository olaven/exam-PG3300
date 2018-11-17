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
            var itemForSale = Items[0]; 
            Items.Remove(itemForSale);
            Market.Instance.AddItem(itemForSale);
            
            Console.WriteLine("{0} {1} put up their item for sale: {2}", Image, Name, itemForSale.GetInformation());
        }
        
        public bool Haggle(float priceOfItem, float customerBalance)
        {
            //Console.WriteLine("HAGGEL: " + priceOfItem + " _ " + customerBalance);
            float f = new Random().Next(0, 100);
            f = f / 100;
            return f < customerBalance/priceOfItem;
        }
        
    }

}

