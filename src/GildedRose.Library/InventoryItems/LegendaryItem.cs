namespace GildedRose.Library.InventoryItems
{
    public class LegendaryItem : InventoryItem
    {
        public LegendaryItem(Item item) : base(item)
        {
        }

        protected override void UpdateItemQuality()
        {
            // nothing changes
        }

        protected override void UpdateItemSellIn()
        {
            // nothing changes
        }

        protected override void UpdateExpiredItemQuality()
        {
            // nothing changes
        }
    }
}