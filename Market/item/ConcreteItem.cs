 using FleaMarket; 

namespace Item
{
    /// <inheritdoc />
    /// <summary>
    /// A basic item. 
    /// </summary>
    public class ConcreteItem : IItem
    {
        public Person Owner { get; set; }

        private readonly float _price; 
        

        

        public ConcreteItem(float price, Person owner)
        {
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
            return "Item " +
                   "\nPrice: " + getPrice() +
                   "\nOwner: " + Owner + //TODO: Fix en fin toString på person 
                   ""
                ; 
        }

    }
}