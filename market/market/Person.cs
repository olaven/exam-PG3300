using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Market
{
    public abstract class Person
    {
        protected Wallet Wallet;
        protected List<Item> Items;
        protected string Name;

        protected Person() : this("unknown")
        {
        }

        protected Person(string name)
        {
            Wallet = new Wallet();
            Items = new List<Item>();
            this.Name = name;
        }

        protected abstract void Act();


    }
}