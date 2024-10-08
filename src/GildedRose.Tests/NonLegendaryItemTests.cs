using System.Collections.Generic;
using GildedRose.Console;
using GildedRose.Library;
using Xunit;

namespace GildedRose.Tests
{
    public class NonLegendaryItemTests
    {
        [Fact]
        public void UpdateQuality_NameNotEqualToSulfurasHandOfRagnarosAtEndOfDay_ReturnsSellInMinusOne()
        {
            // Arrange
            var items = new List<Item> { new Item { Name = "Duck Feather", SellIn = 59, Quality = 8 }};
            var app = new Program{Items = items};

            // Act
            app.ProgressDay();

            // Assert
            Assert.Equal(58, items[0].SellIn);
        }
    }
}