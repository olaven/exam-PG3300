using System;
using FleaMarket; 

namespace Item
{
    public class ItemFactory
    {
        public void getNew(String name, double price, Person person)
        {
            IItem item  = new ConcreteItem(name, price, person);
            
            
        }
    }
}