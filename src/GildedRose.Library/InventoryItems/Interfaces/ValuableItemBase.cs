namespace GildedRose.Library.InventoryItems.Interfaces
{
    public abstract class ValuableItemBase : NonLegendaryItem
    {
        private const int MaximumItemQuality = 50;

        protected ValuableItemBase(Item item) : base(item)
        {
        }

        protected override int QualityChangeModifier => 1;

        private bool ItemQualityLessThanMaximum()
        {
            return _item.Quality < MaximumItemQuality;
        }
    }
}