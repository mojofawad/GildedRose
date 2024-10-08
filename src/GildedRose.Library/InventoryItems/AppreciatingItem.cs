namespace GildedRose.Library.InventoryItems
{
    public class AppreciatingItem : InventoryItem
    {
        public AppreciatingItem(Item item) : base(item)
        {
        }

        protected override void UpdateItemQuality()
        {
            IncreaseItemQuality();
        }

        protected override void UpdateItemSellIn()
        {
            DecreaseItemSellIn();
        }

        protected override void UpdateExpiredItemQuality()
        {
            IncreaseItemQuality();
        }
    }
}