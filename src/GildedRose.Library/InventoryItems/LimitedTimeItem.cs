namespace GildedRose.Library.InventoryItems
{
    public class LimitedTimeItem : InventoryItem
    {
        public LimitedTimeItem(Item item) : base(item)
        {
        }

        protected override void UpdateItemQuality()
        {
            IncreaseItemQuality();

            if (_item.SellIn < 11)
            {
                IncreaseItemQuality();

                if (_item.SellIn < 6)
                {
                    IncreaseItemQuality();
                }
            }
        }

        protected override void UpdateItemSellIn()
        {
            DecreaseItemSellIn();
        }

        protected override void UpdateExpiredItemQuality()
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