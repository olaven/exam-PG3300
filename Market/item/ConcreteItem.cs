using System; 
using FleaMarket; 

namespace Item
{
    public class ConcreteItem : IItem
    {
        public string Name { get; set; }
        protected double price = 0;
        

        public Person Owner { get; set; }

        public ConcreteItem(string name, double price, Person owner)
        {
            Name = name;
            Owner = owner;
        }
        
        public double getPrice()
        {
            return price;
        }
        
        public string getCondition()
        {
            return ""; 
        }

        public string getDamage()
        {
            return ""; 
        }

        public string getModification()
        {
            return ""; 
        }

        public string getInformation()
        {
            return "" +
                   "\nName: " + Name +
                   "\nPrice: " + getPrice() +
                   "\nOwner: " + Owner + //TODO: Fix en fin toString på person 
                   "\n\n"
                ; 
        }

    }
}