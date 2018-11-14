using System;

namespace Market
{
    public class PriceAdjuster
    {
        Random random = new Random();
        
        /// <summary>
        /// Adjusts the price of the given item.
        /// Having a negative min allows negative
        /// modifications. 
        /// </summary>
        /// <param name="decoratedItem"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public void getNew(ItemDecorator decoratedItem, int min, int max)
        {
            decoratedItem.Price += random.Next(min, max); 
        }
    }
}