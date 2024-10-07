using System.Collections.Generic;
using GildedRose.Console;
using Xunit;

namespace GildedRose.Tests
{
    public class DegradingItemTests
    {
        [Fact]
        public void UpdateQuality_SellInGreaterThanZeroAndQualityGreaterThanZero_ReturnsQualityMinusOne()
        {
            // Arrange
            var items = new List<Item>
            {
                new Item { Name = "SomeDegradingItem", SellIn = 1, Quality = 1 },
                new Item { Name = "SomeDegradingItem", SellIn = 1, Quality = 2 }
            };
            var app = new Program{Items = items};

            // Act
            app.ProgressDay();

            // Assert
            Assert.Equal(0, items[0].Quality);
            Assert.Equal(1, items[1].Quality);
        }

        [Fact]
        public void UpdateQuality_SellInLessThanOrEqualToZeroAndQualityGreaterThanOne_ReturnsQualityMinusTwo()
        {
            // Arrange
            var items = new List<Item>
            {
                new Item { Name = "SomeDegradingItem", SellIn = 0, Quality = 2 },
                new Item { Name = "SomeDegradingItem", SellIn = 0, Quality = 4 },
                new Item { Name = "SomeDegradingItem", SellIn = -1, Quality = 2 },
                new Item { Name = "SomeDegradingItem", SellIn = -4, Quality = 4 }
            };
            var app = new Program{Items = items};

            // Act
            app.ProgressDay();

            // Assert
            Assert.Equal(0, items[0].Quality);
            Assert.Equal(2, items[1].Quality);
            Assert.Equal(0, items[2].Quality);
            Assert.Equal(2, items[3].Quality);
        }

        [Fact]
        public void UpdateQuality_SellInLessThanOrEqualToZeroAndQualityEqualToOne_ReturnsQualityEqualToZero()
        {
            // Arrange
            var items = new List<Item>
            {
                new Item { Name = "SomeDegradingItem", SellIn = 0, Quality = 1 },
                new Item { Name = "SomeDegradingItem", SellIn = -1, Quality = 1 }
            };
            var app = new Program{Items = items};

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
            var items = new List<Item> { new Item { Name = "SomeDegradingItem", SellIn = 3, Quality = 0 }};
            var app = new Program{Items = items};

            // Act
            app.ProgressDay();

            // Assert
            Assert.Equal(0, items[0].Quality);
        }
    }
}