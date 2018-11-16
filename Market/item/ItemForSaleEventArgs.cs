using System;
using Item;

namespace FleaMarket
{
    public class ItemForSaleEventArgs : EventArgs
    {
        public ItemForSaleEventArgs(IItem item)
        {
            this.Item = item;
        }

        public IItem Item { get; private set; }
    }

}