using System;
using FleaMarket; 

namespace Item
{

  
    public interface IItem
    {
        String Name { get; set; }
        Person Owner { get; set; }


        float getPrice();
        string getCondition();
        string getDamage();
        string getModification();
        string getInformation(); 
    }
    
    
}