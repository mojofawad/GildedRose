namespace GildedRose.Library.InventoryItems
{
    public class DegradingItem : InventoryItem
    {
        public DegradingItem(Item item) : base(item)
        {
        }

        protected override void UpdateItemQuality()
        {
            DecreaseItemQuality();
        }

        protected override void UpdateItemSellIn()
        {
            DecreaseItemSellIn();
        }

        protected override void UpdateExpiredItemQuality()
        {
            DecreaseItemQuality();
        }

        private void DecreaseItemQuality()
        {
            if (ItemQualityGreaterThanMinimum())
            {
                _item.Quality = _item.Quality - 1;
            }
        }
    }
}