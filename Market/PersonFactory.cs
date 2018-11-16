using System;
using System.Collections;

namespace FleaMarket
{
    /// <summary>
    /// Static class for creating
    /// Person-instances.
    /// </summary>
    public class PersonFactory
    {
        private static readonly ArrayList _names = new ArrayList
        {
            "Petter", "Lars", "Carrie", "Nils", "Dormammu", 
            "Hank", "Simon", "Mary", "Elon", "Tom", "Frank Jr.", 
            "Guro", "Toad", "Zelda", "James", "David", "Molly"
        };
        private static readonly Random _random = new Random();
        
        
        /// <summary>
        /// Manufactures and returns a person. 
        /// </summary>
        /// <param name="type">The type of person</param>
        /// <returns>A person</returns>
        /// <exception cref="Exception"></exception>
        public static Person getPerson(PersonType type)
        {
            switch (type)
            {
                case PersonType.Customer: 
                    return new Customer(GetRandomName());
                case PersonType.Salesman: 
                    return new Salesman(GetRandomName()); 
                default: 
                    throw new Exception("Invalid person specified");
            }
        }
        
        /// <summary>
        /// Gets names that are not taken.
        /// When every name is taken, a
        /// default name, "John Doe", is used. 
        /// </summary>
        /// <returns>A name</returns>
        private static string GetRandomName()
        {
            if (_names.Count < 1)
            {
                return "John Doe";
            }
            var r = _random.Next(0, _names.Count);
            string name = (string) _names[r];
            _names.RemoveAt(r);
            return name;
        }
    }
}



