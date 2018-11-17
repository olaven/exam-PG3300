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
        
        public float GetPrice()
        {
            return _price;
        }
        
        public string GetCondition()
        {
            return ""; 
        }

        public string GetDamage()
        {
            return ""; 
        }

        public string GetModification()
        {
            return ""; 
        }

        public string GetInformation()
        {
            return "" +
                   "Name: " + Name +
                   "\nPrice: " + GetPrice() +
                   "\nOwner: " + Owner + //TODO: Fix en fin toString på person 
                   ""
                ; 
        }

    }
}