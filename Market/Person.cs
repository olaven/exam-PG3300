using System;
using Item; 
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace FleaMarket
{
    public abstract class Person
    {
        protected Wallet Wallet;
        protected List<IItem> Items;
        protected string Name;

        protected Person(string name)
        {
            Wallet = new Wallet();
            Items = new List<IItem>();
            this.Name = name;
        }

        public string GetName()
        {
            return Name;
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