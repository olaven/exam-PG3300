using System;
using FleaMarket; 

namespace Item
{
    public abstract class ItemDecorator : IItem
    {
        private readonly IItem _item;
        protected readonly PriceAdjuster priceAdjuster; 
        
        public string Name { get; set; }
        public double Price { get; set; }
        public Person Owner { get; set; }

        protected ItemDecorator(IItem original)
        {
            _item = original; 
            priceAdjuster = new PriceAdjuster();

            Name = _item.Name;
            Price = _item.Price;
            Owner = _item.Owner; 
        }

        public virtual string getCondition()
        {
            return _item.getCondition(); 
        }

        public virtual string getDamage()
        {
            return _item.getDamage(); 
        }

        public virtual string getModification()
        {
            return _item.getModification(); 
        }

        public string getInformation()
        {
            return "" +
                   "\nName: " + _item.Name +
                   "\nPrice: " + _item.Price +
                   "\nOwner: " + _item.Owner + //TODO: Fix en fin toString på person 
                   "\n\n" +
                   
                   "\nCondition: " + getCondition() +
                   "\nDamage: " + getDamage() +
                   "\nModification: " + getModification() +
                   "\n\n"
                ; 
        }
    }
}