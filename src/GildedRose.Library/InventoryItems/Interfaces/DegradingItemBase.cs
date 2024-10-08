using System;

namespace GildedRose.Library.InventoryItems.Interfaces
{
    public abstract class DegradingItemBase : NonLegendaryItem
    {
        private const int MinimumItemQuality = 0;

        protected DegradingItemBase(Item item) : base(item)
        {
        }

        protected virtual int QualityDecreaseRate => 1;

        public override void UpdateItemQuality()
        {
            DecreaseItemQuality();
        }

        public override void UpdateExpiredItemQuality()
        {
            DecreaseItemQuality();
        }

        private void DecreaseItemQuality()
        {
            if (ItemQualityGreaterThanMinimum())
            {
                _item.Quality = Math.Max(_item.Quality - QualityDecreaseRate, MinimumItemQuality);
            }
        }

        private bool ItemQualityGreaterThanMinimum()
        {
            return _item.Quality > MinimumItemQuality;
        }
    }
}