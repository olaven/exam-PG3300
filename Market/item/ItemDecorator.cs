using System;
using FleaMarket; 

namespace Item
{
    /// <summary>
    /// The item decorator extends *and* has an IItem.
    /// Implementing IItem is done by using the IItem
    /// internally to delegate functionality to it.
    /// 
    /// This is part of the decorator pattern, allowing
    /// us to decorate (add functionality) in runtime. 
    /// </summary>
    public abstract class ItemDecorator : IItem
    {
        private readonly IItem _item;
        protected readonly Random Random;
        public string Name { get; set; }
        public Person Owner { get; set; }

        protected int PriceAdjustment;

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
        }
    }
}