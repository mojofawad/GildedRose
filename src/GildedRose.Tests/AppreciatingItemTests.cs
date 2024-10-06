using System.Collections.Generic;
using GildedRose.Console;
using Xunit;

namespace GildedRose.Tests
{
    public class AppreciatingItemTests
    {
        [Fact]
        public void UpdateQuality_NameIsAgedBrieAndSellInGreaterThanZeroAndQualityLessThanFifty_ReturnsQualityPlusOne()
        {
            // Arrange
            var items = new List<Item>
            {
                new Item { Name = "Aged Brie", SellIn = 3, Quality = 0 },
                new Item { Name = "Aged Brie", SellIn = 3, Quality = 5 },
                new Item { Name = "Aged Brie", SellIn = 3, Quality = 49 }
            };
            var app = new Program{Items = items};

            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(1, items[0].Quality);
            Assert.Equal(6, items[1].Quality);
            Assert.Equal(50, items[2].Quality);
        }
        
        [Fact]
        public void UpdateQuality_NameIsAgedBrieAndSellInLessThanOrEqualToZeroAndQualityLessThanFortyNine_ReturnsQualityPlusTwo()
        {
            // Arrange
            var items = new List<Item>
            {
                new Item { Name = "Aged Brie", SellIn = -2, Quality = 0 },
                new Item { Name = "Aged Brie", SellIn = 0, Quality = 7 },
                new Item { Name = "Aged Brie", SellIn = 0, Quality = 48 },
                new Item { Name = "Aged Brie", SellIn = -2, Quality = 48 }
            };
            var app = new Program{Items = items};

            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(2, items[0].Quality);
            Assert.Equal(9, items[1].Quality);
            Assert.Equal(50, items[2].Quality);
            Assert.Equal(50, items[2].Quality);
        }
        
        [Fact]
        public void UpdateQuality_NameIsAgedBrieAndQualityEqualToFortyNine_ReturnsQualityEqualToFifty()
        {
            // Arrange
            var items = new List<Item>
            {
                new Item { Name = "Aged Brie", SellIn = -1, Quality = 49 },
                new Item { Name = "Aged Brie", SellIn = 2, Quality = 49 },
                new Item { Name = "Aged Brie", SellIn = 0, Quality = 49 }
            };
            var app = new Program{Items = items};

            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(50, items[0].Quality);
            Assert.Equal(50, items[1].Quality);
            Assert.Equal(50, items[2].Quality);
        }
        
        [Fact]
        public void UpdateQuality_NameIsAgedBrieAndQualityEqualToFifty_ReturnsQualityEqualToFifty()
        {
            // Arrange
            var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 34, Quality = 50 }};
            var app = new Program{Items = items};

            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(50, items[0].Quality);
        }
    }
}