using System.Collections.Generic;

namespace Market
{
    public class Market
    {
        private static Market _market;
        private List<Item> _items;

        private Market()
        {
            //private to prohobit instantiation of market object for other classes.
            _items = new List<Item>();
            
        }
        
        public static Market Instance
        {
            get { return _market ?? (_market = new Market()); }     
        }


    }
}