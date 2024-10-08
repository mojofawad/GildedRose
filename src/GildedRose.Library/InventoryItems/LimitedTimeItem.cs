using GildedRose.Library.InventoryItems.Interfaces;

namespace GildedRose.Library.InventoryItems
{
    public class LimitedTimeItem : ValuableItemBase
    {
        public LimitedTimeItem(Item item) : base(item)
        {
            UpdateQualityIncreaseRate();
        }

        private void UpdateQualityIncreaseRate()
        {
            if (_item.SellIn < 11)
            {
                QualityIncreaseRate++;

                if (_item.SellIn < 6)
                {
                    QualityIncreaseRate++;
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