using GildedRose.Library.InventoryItems.Interfaces;

namespace GildedRose.Library.InventoryItems
{
    public class LimitedTimeItem : ValuableItemBase
    {
        private int _qualityChangeModifier = 1;

        public LimitedTimeItem(Item item) : base(item)
        {
            UpdateQualityChangeModifier();
        }

        protected override int QualityChangeModifier => _qualityChangeModifier;

        private void UpdateQualityChangeModifier()
        {
            if (_item.SellIn < 11)
            {
                _qualityChangeModifier++;

                if (_item.SellIn < 6)
                {
                    _qualityChangeModifier++;
                }
            }
        }

        public override void UpdateExpiredItemQuality()
        {
            if (_item.SellIn < 0)
            {
                ZeroOutItemQuality();
            }
        }

        private void ZeroOutItemQuality()
        {
            _item.Quality = _item.Quality - _item.Quality;
        }
    }
}