 using FleaMarket; 

namespace Item
{
    /// <inheritdoc />
    /// <summary>
    /// A basic item. 
    /// </summary>
    public class ConcreteItem : IItem
    {
        public string Name { get; set; }
        public Person Owner { get; set; }

        private readonly float _price; 
        

        

        public ConcreteItem(string name, float price, Person owner)
        {
            Name = name;
            Owner = owner;

            if (price > 0)
            {
                this._price = price; 
            }
        }
        
        public float getPrice()
        {
            return _price;
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
                   "Name: " + Name +
                   "\nPrice: " + getPrice() +
                   "\nOwner: " + Owner + //TODO: Fix en fin toString på person 
                   ""
                ; 
        }

    }
}