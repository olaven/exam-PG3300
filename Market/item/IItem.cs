using System;
using FleaMarket; 

namespace Item
{

  
    public interface IItem
    {
        String Name { get; set; }
        Person Owner { get; set; }


        double getPrice();
        String getCondition();
        String getDamage();
        String getModification();
        String getInformation(); 
    }
    
    
}