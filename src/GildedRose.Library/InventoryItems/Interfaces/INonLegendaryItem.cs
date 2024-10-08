namespace GildedRose.Library.InventoryItems.Interfaces
{
    public interface INonLegendaryItem : IInventoryItem
    {
        void UpdateItemQuality();
        void UpdateItemSellIn();
        void UpdateExpiredItemQuality();
    }
}