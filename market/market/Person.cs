using System.Collections.Generic;

namespace Market
{
    public abstract class Person
    {
        protected Wallet _wallet;
        protected List<Item> _items;

        public Person()
        {
            _wallet = new Wallet();
            _items = new List<Item>();
        }


    }
}