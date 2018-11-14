using System;

namespace Market
{
    public interface Item
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