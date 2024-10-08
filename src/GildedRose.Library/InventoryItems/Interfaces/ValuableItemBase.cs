namespace GildedRose.Library.InventoryItems.Interfaces
{
    public abstract class ValuableItemBase : NonLegendaryItem
    {
        protected ValuableItemBase(Item item) : base(item)
        {
        }

        protected override int QualityChangeModifier => 1;
    }
}