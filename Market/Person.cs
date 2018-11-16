using System;
using Item; 
using System.Collections.Generic;

namespace FleaMarket
{
    /// <summary>
    /// Encapsulating the concept of
    /// a person. Is never directly instanciated
    /// (is abstract), but is extended by
    /// Salesman and Customer.
    /// Each person has:
    /// <list type="bullet">
    ///    <item>A name</item>
    ///    <item>A wallet</item>
    ///    <item>A list of belongings</item>
    /// </list>
    /// </summary>
    public abstract class Person
    {
        public string Name { get; }
        public Wallet Wallet { get; }
        protected readonly List<IItem> Items;
        
        
        protected Person(string name)
        {
            Name = name;
            Wallet = new Wallet();
            Items = new List<IItem>();
        }

        public List<IItem> GetItems()
        {
            return Items;
        }

    }
}