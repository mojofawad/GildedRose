using GildedRose.Library.Enumerations;
using GildedRose.Library.InventoryItems.Interfaces;

namespace GildedRose.Library.InventoryItems
{
    public class LegendaryItem : ILegendaryItem
    {
        public LegendaryItem(Item item)
        {
        }

        public InventoryItemType InventoryItemType => InventoryItemType.Legendary;
        public string LegendaryItemLore => "Legendary items never change";

        public void UpdateItem()
        {
            // nothing changes
        }
    }
}