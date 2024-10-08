namespace GildedRose.Library.InventoryItems
{
    public class ConjuredItem : DegradingItem
    {
        public ConjuredItem(Item item) : base(item)
        {
            
        }

        protected override void UpdateItemQuality()
        {
            DecreaseItemQuality();
            DecreaseItemQuality();
        }

        protected override void UpdateItemSellIn()
        {
            DecreaseItemSellIn();
        }

        protected override void UpdateExpiredItemQuality()
        {
            DecreaseItemQuality();
            DecreaseItemQuality();
        }
    }
}