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

        protected int _priceAdjustment;

        protected ItemDecorator(IItem original)
        {
            _item = original; 

            Name = _item.Name;
            Owner = _item.Owner; 
            Random = new Random();        
            
        }
        
        #region Delegated methods 
        
        public virtual float getPrice()
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
        #endregion

        public string getInformation()
        {
            return "" + Name + 
                   " with " + 
                   getModification() + 
                   " in " + getCondition() + 
                   " that has " + getDamage() +
                   " for " + getPrice() + ",-";
            /*return "" +
                   "\nName: " + _item.Name +
                   "\nPrice: " + _item.getPrice() +
                   "\nOwner: " + _item.Owner + //TODO: Fix en fin toString på person 
                   "\n\n" +
                   
                   "\nCondition: " + getCondition() +
                   "\nDamage: " + getDamage() +
                   "\nModification: " + getModification() +
                   "\n\n"
                ; 
                */
        }
    }
}