using System.Collections.Generic;
using GildedRose.Console;
using GildedRose.Library;
using Xunit;

namespace GildedRose.Tests
{
    public class ConjuredItemTests
    {
        [Fact]
        public void UpdateQuality_SellInGreaterThanZeroAndQualityGreaterThanOne_ReturnsQualityMinusTwo()
        {
            // Arrange
            var items = new List<Item>
            {
                new Item { Name = "Conjured Mana Cake", SellIn = 1, Quality = 3 },
                new Item { Name = "Conjured Mana Cake", SellIn = 1, Quality = 2 }
            };
            var app = new Program { Items = items };

            // Act
            app.ProgressDay();

            // Assert
            Assert.Equal(1, items[0].Quality);
            Assert.Equal(0, items[1].Quality);
        }

        [Fact]
        public void UpdateQuality_SellInLessThanOrEqualToZeroAndQualityGreaterThanThree_ReturnsQualityMinusFour()
        {
            // Arrange
            var items = new List<Item>
            {
                new Item { Name = "Conjured Mana Cake", SellIn = 0, Quality = 4 },
                new Item { Name = "Conjured Mana Cake", SellIn = 0, Quality = 5 },
                new Item { Name = "Conjured Mana Cake", SellIn = -1, Quality = 4 },
                new Item { Name = "Conjured Mana Cake", SellIn = -4, Quality = 5 }
            };
            var app = new Program { Items = items };

            // Act
            app.ProgressDay();

            // Assert
            Assert.Equal(0, items[0].Quality);
            Assert.Equal(1, items[1].Quality);
            Assert.Equal(0, items[2].Quality);
            Assert.Equal(1, items[3].Quality);
        }

        [Fact]
        public void UpdateQuality_SellInLessThanOrEqualToZeroAndQualityEqualToThree_ReturnsQualityEqualToZero()
        {
            // Arrange
            var items = new List<Item>
            {
                new Item { Name = "Conjured Mana Cake", SellIn = 0, Quality = 3 },
                new Item { Name = "Conjured Mana Cake", SellIn = -1, Quality = 3 }
            };
            var app = new Program { Items = items };

            // Act
            app.ProgressDay();

            // Assert
            Assert.Equal(0, items[0].Quality);
            Assert.Equal(0, items[1].Quality);
        }

        [Fact]
        public void UpdateQuality_QualityEqualToZero_ReturnsQualityEqualToZero()
        {
            // Arrange
            var items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 0 } };
            var app = new Program { Items = items };

            // Act
            app.ProgressDay();

            // Assert
            Assert.Equal(0, items[0].Quality);
        }
    }
}