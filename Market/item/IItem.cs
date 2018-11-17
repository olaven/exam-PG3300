using System;
using FleaMarket; 

namespace Item
{
    /// <summary>
    /// Defines an interface for items.
    /// </summary>
    public interface IItem
    {
        Person Owner { get; set; }

        /// <returns>The price of an item</returns>
        float GetPrice();
        /// <returns>The price condition of an item</returns>
        string GetCondition();
        /// <returns>The damage level of an item</returns>
        string GetDamage();
        /// <returns>The modification of an item</returns>
        string GetModification();
        
        /// <returns>All information about the item</returns>
        string GetInformation(); 
    }
    
    
}