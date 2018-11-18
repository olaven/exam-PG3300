using System;
using Item; 
using System.Collections.Generic;

namespace People
{
    /// <summary>
    /// Encapsulating the concept of
    /// a person. Is never directly instanciated
    /// (is abstract), but is extended by
    /// Salesman and Customer.
    ///
    /// It is abstract, as having a person
    /// without a specialization does not
    /// make sense in our context.  
    /// 
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

        public string Image => PersonImagePointer.PersonImage.Image;


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