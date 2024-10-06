using System.Collections.Generic;
using GildedRose.Console;
using Xunit;

namespace GildedRose.Tests
{
    public class DegradingItemTests
    {
        [Fact]
        public void UpdateQuality_AtEndOfDay_ReturnsSellInMinusOne()
        {
            // Arrange
            var items = new List<Item> { new Item { Name = "SomeDegradingItem", SellIn = 5, Quality = 8 }};
            var app = new Program{Items = items};

            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(4, items[0].SellIn);
        }

        [Fact]
        public void UpdateQuality_SellInGreaterThanOrEqualToZeroAndQualityGreaterThanZero_ReturnsQualityMinusOne()
        {
            // Arrange
            var items = new List<Item> { new Item { Name = "SomeDegradingItem", SellIn = 3, Quality = 4 }};
            var app = new Program{Items = items};

            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(3, items[0].Quality);
        }

        [Fact]
        public void UpdateQuality_SellInLessThanZeroAndQualityGreaterThanOne_ReturnsQualityMinusTwo()
        {
            // Arrange
            var items = new List<Item> { new Item { Name = "SomeDegradingItem", SellIn = -3, Quality = 7 }};
            var app = new Program{Items = items};

            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(5, items[0].Quality);
        }

        [Fact]
        public void UpdateQuality_SellInLessThanZeroAndQualityEqualToOne_ReturnsQualityEqualToZero()
        {
            // Arrange
            var items = new List<Item> { new Item { Name = "SomeDegradingItem", SellIn = -3, Quality = 1 }};
            var app = new Program{Items = items};

            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(0, items[0].Quality);
        }

        [Fact]
        public void UpdateQuality_QualityEqualToZero_ReturnsQualityEqualToZero()
        {
            // Arrange
            var items = new List<Item> { new Item { Name = "SomeDegradingItem", SellIn = 3, Quality = 0 }};
            var app = new Program{Items = items};

            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(0, items[0].Quality);
        }
    }
}