using System;
using FleaMarket; 

namespace Item
{
    public abstract class ItemDecorator : IItem
    {
        private readonly IItem _item;
        protected readonly Random Random;
        public string Name { get; set; }
        public Person Owner { get; set; }

        protected ItemDecorator(IItem original)
        {
            _item = original; 

            Name = _item.Name;
            Owner = _item.Owner; 
            Random = new Random();        
            
        }
        
        
        public virtual double getPrice()
        {
            return _item.getPrice();
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
                   "\nPrice: " + _item.getPrice() +
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