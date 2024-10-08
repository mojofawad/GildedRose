namespace GildedRose.Library.InventoryItems.Interfaces
{
    public interface ILegendaryItem : IInventoryItem
    {
        string LegendaryItemLore { get; }
    }
}