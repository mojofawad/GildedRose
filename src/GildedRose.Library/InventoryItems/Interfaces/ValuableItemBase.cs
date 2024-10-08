using System;

namespace GildedRose.Library.InventoryItems.Interfaces
{
    public abstract class ValuableItemBase : NonLegendaryItem
    {
        private const int MaximumItemQuality = 50;

        protected ValuableItemBase(Item item) : base(item)
        {
        }

        protected virtual int QualityIncreaseRate { get; set; } = 1;

        public override void UpdateItemQuality()
        {
            IncreaseItemQuality();
        }

        public override void UpdateExpiredItemQuality()
        {
            IncreaseItemQuality();
        }

        private void IncreaseItemQuality()
        {
            if (ItemQualityLessThanMaximum())
            {
                // _item.Quality = _item.Quality + 1;
                _item.Quality = Math.Min(_item.Quality + QualityIncreaseRate, MaximumItemQuality);
            }
        }

        private bool ItemQualityLessThanMaximum()
        {
            return _item.Quality < MaximumItemQuality;
        }
    }
}