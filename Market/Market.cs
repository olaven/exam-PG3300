using System.Collections.Generic;
using Item; 

namespace FleaMarket
{
    public class Market
    {
        private static Market _market;
        private List<IItem> _items;

        private Market()
        {
            //private to prohibit instantiation of market object for other classes.
            _items = new List<IItem>();
            
        }
        
        public static Market Instance
        {
            get { return _market ?? (_market = new Market()); }     
        }


    }
}