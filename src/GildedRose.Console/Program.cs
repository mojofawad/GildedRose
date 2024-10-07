using System.Collections.Generic;

namespace GildedRose.Console
{
    public class Program
    {
        public IList<Item> Items;

        static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            var app = new Program()
            {
                Items = new List<Item>
                {
                    new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 },
                    new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 },
                    new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 },
                    new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 },
                    new Item
                    {
                        Name = "Backstage passes to a TAFKAL80ETC concert",
                        SellIn = 15,
                        Quality = 20
                    },
                    new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 }
                }
            };

            app.ProgressDay();

            System.Console.ReadKey();
        }

        public void ProgressDay()
        {
            foreach (var item in Items)
            {
                UpdateQuality(item);
            }
        }

        private static void UpdateQuality(Item item)
        {
            if (IsLegendaryItem(item))
            {
                UpdateLegendaryItem(item);
            }
            else if (IsLimitedTimeItem(item))
            {
                UpdateLimitedTimeItemQuality(item);
            }
            else if (IsAgingItem(item))
            {
                UpdateAgingItemQuality(item);
            }
            else
            {
                UpdateDegradingItemQuality(item);
            }
        }

        private static void UpdateDegradingItemQuality(Item item)
        {
            DecreaseItemQuality(item);

            DecreaseItemSellIn(item);

            if (ItemSellInLessThanZero(item))
            {
                DecreaseItemQuality(item);
            }
        }

        private static void UpdateAgingItemQuality(Item item)
        {
            IncreaseItemQuality(item);

            DecreaseItemSellIn(item);
            if (ItemSellInLessThanZero(item))
            {
                IncreaseItemQuality(item);
            }
        }

        private static void UpdateLimitedTimeItemQuality(Item item)
        {
            IncreaseItemQuality(item);

            if (item.SellIn < 11)
            {
                IncreaseItemQuality(item);

                if (item.SellIn < 6)
                {
                    IncreaseItemQuality(item);
                }
            }

            DecreaseItemSellIn(item);

            if (ItemSellInLessThanZero(item))
            {
                ZeroOutItemQuality(item);
            }
        }

        private static void UpdateLegendaryItem(Item item)
        {
            // nothing changes
        }

        private static bool IsAgingItem(Item item)
        {
            return item.Name == "Aged Brie";
        }

        private static bool IsLimitedTimeItem(Item item)
        {
            return item.Name == "Backstage passes to a TAFKAL80ETC concert";
        }

        private static bool IsLegendaryItem(Item item)
        {
            return item.Name == "Sulfuras, Hand of Ragnaros";
        }

        private static void IncreaseItemQuality(Item item)
        {
            if (ItemQualityLessThanMaximum(item))
            {
                item.Quality = item.Quality + 1;
            }
        }

        private static void DecreaseItemQuality(Item item)
        {
            if (ItemQualityGreaterThanMinimum(item))
            {
                item.Quality = item.Quality - 1;
            }
        }

        private static bool ItemQualityLessThanMaximum(Item item)
        {
            const int maxQuality = 50;
            return item.Quality < maxQuality;
        }

        private static bool ItemQualityGreaterThanMinimum(Item item)
        {
            const int minQuality = 0;
            return item.Quality > minQuality;
        }

        private static void ZeroOutItemQuality(Item item)
        {
            item.Quality = item.Quality - item.Quality;
        }

        private static bool ItemSellInLessThanZero(Item item)
        {
            return item.SellIn < 0;
        }

        private static void DecreaseItemSellIn(Item item)
        {
            item.SellIn = item.SellIn - 1;
        }
    }
}