using System;
using GildedRose.Library.Enumerations;

namespace GildedRose.Library.InventoryItems
{
    public static class InventoryItemFactory
    {
        public static InventoryItem CreateInventoryItem(Item item)
        {
            var itemType = GetItemType(item);
            switch (itemType)
            {
                case InventoryItemType.Appreciating:
                    return new AppreciatingItem(item);
                case InventoryItemType.LimitedTime:
                    return new LimitedTimeItem(item);
                case InventoryItemType.Legendary:
                    return new LegendaryItem(item);
                case InventoryItemType.Conjured:
                    return new ConjuredItem(item);
                case InventoryItemType.Degrading:
                    return new DegradingItem(item);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private static InventoryItemType GetItemType(Item item)
        {
            switch (item.Name)
            {
                case "Aged Brie":
                    return InventoryItemType.Appreciating;
                case "Backstage passes to a TAFKAL80ETC concert":
                    return InventoryItemType.LimitedTime;
                case "Sulfuras, Hand of Ragnaros":
                    return InventoryItemType.Legendary;
                case "Conjured Mana Cake":
                    return InventoryItemType.Conjured;
                default:
                    return InventoryItemType.Degrading;
            }
        }
    }
}