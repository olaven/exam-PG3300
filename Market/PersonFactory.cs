using System;
using System.Collections;

namespace FleaMarket
{
    public class PersonFactory
    {
        private static readonly ArrayList _names = new ArrayList{"Petter", "Lars", "Carrie", "Nils", "Dormammu", "Hank", "Simon", "Mary", "Elon", "Tom", "Frank Jr." };
        private static readonly Random _random = new Random();
        
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