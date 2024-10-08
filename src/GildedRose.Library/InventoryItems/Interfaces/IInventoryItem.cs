using GildedRose.Library.Enumerations;

namespace GildedRose.Library.InventoryItems.Interfaces
{
    public interface IInventoryItem
    {
        InventoryItemType InventoryItemType { get; }
        void UpdateItem();
    }
}