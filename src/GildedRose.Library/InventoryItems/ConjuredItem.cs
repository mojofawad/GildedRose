using GildedRose.Library.InventoryItems.Interfaces;

namespace GildedRose.Library.InventoryItems
{
    public class ConjuredItem : DegradingItemBase
    {
        public ConjuredItem(Item item) : base(item)
        {
        }

        protected override int QualityChangeModifier => -2;
    }
}