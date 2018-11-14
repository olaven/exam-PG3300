using System;

namespace Market
{
    public class ItemFactory
    {
        public void getNew(String name, double price, Person person)
        {
            Item item  = new ConcreteItem(name, price, person);
            
            
        }
    }
}