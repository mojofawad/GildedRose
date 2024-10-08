using GildedRose.Library.Enumerations;

namespace GildedRose.Library.InventoryItems.Interfaces
{
    public abstract class NonLegendaryItem : INonLegendaryItem
    {
        internal readonly Item _item;

        protected NonLegendaryItem(Item item)
        {
            _item = item;
        }

        public InventoryItemType InventoryItemType { get; }

        public virtual void UpdateItem()
        {
            UpdateItemQuality();

            UpdateItemSellIn();

            if (ItemSellInLessThanZero())
            {
                UpdateExpiredItemQuality();
            }
        }

        public abstract void UpdateItemQuality();

        public void UpdateItemSellIn()
        {
            _item.SellIn = _item.SellIn - 1;
        }

        public abstract void UpdateExpiredItemQuality();

        private bool ItemSellInLessThanZero()
        {
            return _item.SellIn < 0;
        }
    }
}