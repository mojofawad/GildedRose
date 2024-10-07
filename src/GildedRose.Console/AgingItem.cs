namespace GildedRose.Console
{
    public class AgingItem : InventoryItem
    {
        public AgingItem(Item item) : base(item)
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