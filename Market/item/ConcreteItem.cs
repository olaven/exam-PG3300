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
        private readonly string _itemName;
        private readonly float _price;

        public ConcreteItem(float price, Salesman owner)
        {
            Owner = owner;
            _itemName = owner.Name + "'s item #" + owner.GetItemCount();
    
            if (price > 0)
            {
                _price = price; 
            }
        }

        public string GetName()
        {
            return _itemName;
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
            return _itemName +  
                " for " + GetPrice() + ",-";
        }
    }
}