using System;
using System.Collections;

namespace People
{
    /// <summary>
    /// Static class for creating
    /// Person-instances.
    /// </summary>
    public class PersonFactory
    {
        private static readonly ArrayList Names = new ArrayList
        {
            "Petter", "Lars", "Carrie", "Nils", "Dormammu", 
            "Hank", "Simon", "Mary", "Elon", "Tom", "Frank Jr.", 
            "Guro", "Toad", "Zelda", "James", "David", "Molly"
        };
        private static readonly Random Random = new Random();
        
        
        /// <summary>
        /// Manufactures and returns a person. 
        /// </summary>
        /// <param name="type">The type of person</param>
        /// <returns>A person</returns>
        /// <exception cref="Exception"></exception>
        public static Person GetPerson(PersonType type)
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
            if (Names.Count < 1)
            {
                return "John Doe";
            }
            var r = Random.Next(0, Names.Count);
            string name = (string) Names[r];
            Names.RemoveAt(r);
            return name;
        }
    }
}



