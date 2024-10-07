namespace GildedRose.Console
{
    public abstract class InventoryItem
    {
        protected readonly Item _item;

        protected InventoryItem(Item item)
        {
            _item = item;
        }

        public void UpdateQuality()
        {
            UpdateItemQuality();

            UpdateItemSellIn();

            if (ItemSellInLessThanZero())
            {
                UpdateExpiredItemQuality();
            }
        }

        protected abstract void UpdateItemQuality();
        protected abstract void UpdateItemSellIn();
        protected abstract void UpdateExpiredItemQuality();

        protected void IncreaseItemQuality()
        {
            if (ItemQualityLessThanMaximum())
            {
                _item.Quality = _item.Quality + 1;
            }
        }

        private bool ItemQualityLessThanMaximum()
        {
            const int maxQuality = 50;
            return _item.Quality < maxQuality;
        }

        protected bool ItemQualityGreaterThanMinimum()
        {
            const int minQuality = 0;
            return _item.Quality > minQuality;
        }

        private bool ItemSellInLessThanZero()
        {
            return _item.SellIn < 0;
        }

        protected void DecreaseItemSellIn()
        {
            _item.SellIn = _item.SellIn - 1;
        }
    }
}