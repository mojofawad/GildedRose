namespace GildedRose.Console
{
    public static class InventoryItemFactory
    {
        public static InventoryItem CreateInventoryItem(Item item)
        {
            switch (item.Name)
            {
                case "Aged Brie":
                    return new AgingItem(item);
                case "Backstage passes to a TAFKAL80ETC concert":
                    return new LimitedTimeItem(item);
                case "Sulfuras, Hand of Ragnaros":
                    return new LegendaryItem(item);
                default:
                    return new DegradingItem(item);
            }
        }
    }
}