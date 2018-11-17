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
        float getPrice();
        /// <returns>The price condition of an item</returns>
        string getCondition();
        /// <returns>The damage level of an item</returns>
        string getDamage();
        /// <returns>The modification of an item</returns>
        string getModification();
        
        /// <returns>All information about the item</returns>
        string getInformation(); 
    }
    
    
}