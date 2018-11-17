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

            return "Item " +
                   "\nPrice: " + GetPrice() +
                   "\nOwner: " + Owner + //TODO: Fix en fin toString på person 
                   ""
                ; 
        }

    }
}