using System;
using GildedRose.Library.Enumerations;

namespace GildedRose.Library.InventoryItems.Interfaces
{
    public abstract class NonLegendaryItem : INonLegendaryItem
    {
        private const int MaximumItemQuality = 50;
        private const int MinimumItemQuality = 0;
        internal readonly Item _item;

        protected NonLegendaryItem(Item item)
        {
            _item = item;
        }

        protected virtual int QualityChangeModifier { get; set; } = 0;

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

        public void UpdateItemQuality()
        {
            if (QualityChangeModifier > 0)
            {
                _item.Quality = Math.Min(_item.Quality + QualityChangeModifier, MaximumItemQuality);
            }
            else if (QualityChangeModifier < 0)
            {
                _item.Quality = Math.Max(_item.Quality + QualityChangeModifier, MinimumItemQuality);
            }
        }

        public void UpdateItemSellIn()
        {
            _item.SellIn = _item.SellIn - 1;
        }

        public virtual void UpdateExpiredItemQuality()
        {
            UpdateItemQuality();
        }

        private bool ItemSellInLessThanZero()
        {
            return _item.SellIn < 0;
        }
    }
}