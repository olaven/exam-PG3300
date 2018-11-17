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
        public Person Owner { get; set; }

        protected int PriceAdjustment;

        protected ItemDecorator(IItem original)
        {
            _item = original; 
            Owner = _item.Owner; 
            Random = new Random();        
            
        }
        
        #region Delegated methods 

        public string GetName()
        {
            return _item.GetName();
        }

        public virtual float GetPrice()
        {
            return _item.GetPrice();
        }

        public virtual string GetCondition()
        {
            return _item.GetCondition(); 
        }

        public virtual string GetDamage()
        {
            return _item.GetDamage(); 
        }

        public virtual string GetModification()
        {
            return _item.GetModification(); 
        }
        #endregion

        public string GetInformation()
        {
            return GetName() +  
                   GetModification() + 
                   GetCondition() + 
                   GetDamage() +
                   " for " + GetPrice() + ",-";
        }
    }
}