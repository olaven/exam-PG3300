using System;
using Item;

namespace Item
{
    /// <inheritdoc />
    /// <summary>
    /// This EventArg holds an item.
    /// This allows us to pass the item
    /// through the event customers listen to. 
    /// </summary>
    public class ItemForSaleEventArgs : EventArgs
    {
        public ItemForSaleEventArgs(IItem item)
        {
            this.Item = item;
        }

        public IItem Item { get; }
    }

}