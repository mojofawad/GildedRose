using System.Collections.Generic;
using GildedRose.Console;
using Xunit;

namespace GildedRose.Tests
{
    public class LegendaryItemTests
    {
        [Fact]
        public void UpdateQuality_NameEqualToSulfurasHandOfRagnaros_ReturnsQualityNoChange()
        {
            // Arrange
            var items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 129 }};
            var app = new Program{Items = items};

            // Act
            app.ProgressDay();

            // Assert
            Assert.Equal(129, items[0].Quality);
        }
    }
}