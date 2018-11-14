using System; 
using Market; 

namespace Item
{
    public class ConcreteItem : IItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
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