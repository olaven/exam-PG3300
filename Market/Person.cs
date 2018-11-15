using System;
using Item; 
using System.Collections.Generic;

namespace FleaMarket
{
    public abstract class Person
    {
        public Wallet Wallet { get; }
        public string Name { get; }
        protected List<IItem> Items;
        
        protected Person(string name)
        {
            Wallet = new Wallet();
            Items = new List<IItem>();
            Name = name;
        }

        public List<IItem> GetItems()
        {
            return Items;
        }

        public void AddItem(IItem item)
        {
            Items.Add(item);
        }

        public abstract void Act();


    }
}