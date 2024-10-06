using System.Collections.Generic;
using GildedRose.Console;
using Xunit;

namespace GildedRose.Tests
{
    public class LimitedTimeItemTests
    {
        [Fact]
        public void UpdateQuality_NameIsBackstagePassesAndSellInGreaterThanTenAndQualityLessThanFifty_ReturnsQualityPlusOne()
        {
            // Arrange
            var items = new List<Item>
            {
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 27 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 49 },
            };
            var app = new Program{Items = items};

            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(28, items[0].Quality);
            Assert.Equal(50, items[1].Quality);
        }
        
        [Fact]
        public void UpdateQuality_NameIsBackstagePassesAndSellInLessThanOrEqualToTenAndGreaterThanFiveAndQualityLessThanFortyNine_ReturnsQualityPlusTwo()
        {
            // Arrange
            var items = new List<Item>
            {
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 31 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 6, Quality = 34 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 48 },
            };
            var app = new Program{Items = items};

            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(33, items[0].Quality);
            Assert.Equal(36, items[1].Quality);
            Assert.Equal(50, items[2].Quality);
        }
        
        [Fact]
        public void UpdateQuality_NameIsBackstagePassesAndSellInLessThanOrEqualToFiveAndSellInGreaterThanZeroAndQualityLessThanFortyEight_ReturnsQualityPlusThree()
        {
            // Arrange
            var items = new List<Item>
            {
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 32 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 1, Quality = 38 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 47 },
            };
            var app = new Program{Items = items};

            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(35, items[0].Quality);
            Assert.Equal(41, items[1].Quality);
            Assert.Equal(50, items[2].Quality);
        }
        
        [Fact]
        public void UpdateQuality_NameIsBackstagePassesAndSellInLessThanOrEqualToZero_ReturnsQualityEqualToZero()
        {
            // Arrange
            var items = new List<Item>
            {
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 49 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = -1, Quality = 50 }
            };
            var app = new Program{Items = items};

            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(0, items[0].Quality);
            Assert.Equal(0, items[1].Quality);
        }
    }
}