namespace GildedRose.Library.InventoryItems.Interfaces
{
    public abstract class DegradingItemBase : NonLegendaryItem
    {
        protected DegradingItemBase(Item item) : base(item)
        {
        }

        protected override int QualityChangeModifier => -1;
    }
}