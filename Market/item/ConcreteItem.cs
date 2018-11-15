using System; 
using FleaMarket; 

namespace Item
{
    public class ConcreteItem : IItem
    {
        public string Name { get; set; }
        protected double price = 0;
        public double Price
        {
            get => price;
            set
            {
                if (value > 0)
                {
                    price = value; 
                }
            }
        }

        public Person Owner { get; set; }

        public ConcreteItem(string name, double price, Person owner)
        {
            Name = name;
            Price = price;
            Owner = owner;
        }

        public string getCondition()
        {
            return "not specified"; 
        }

        public string getDamage()
        {
            return "not specified"; 
        }

        public string getModification()
        {
            return "not specified"; 
        }

        public string getInformation()
        {
            return "" +
                   "\nName: " + Name +
                   "\nPrice: " + Price +
                   "\nOwner: " + Owner + //TODO: Fix en fin toString på person 
                   "\n\n"
                ; 
        }

    }
}