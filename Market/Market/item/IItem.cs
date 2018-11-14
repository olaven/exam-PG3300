using System;
using Market; 

namespace Item
{
    public interface IItem
    {
        String Name { get; set; }
        double Price { get; set; }
        Person Owner { get; set; }

        String getCondition();
        String getDamage();
        String getModification();
        String getInformation(); 
    }
}