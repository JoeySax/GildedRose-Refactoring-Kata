using GildedRoseKata;
using GildedRoseKata.Factories;
using System.Collections.Generic;
using Xunit;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        [Fact]
        public void Given_A_Normal_Item_When_A_Day_Passes_Then_The_SellIn_Value_Decreases_By_1()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Normal Item", SellIn = 5, Quality = 10 } };
            GildedRose app = new GildedRose(Items, new ItemStrategyFactory());
            app.UpdateQuality();
            Assert.Equal(4, Items[0].SellIn);
        }

        [Fact]
        public void Given_A_Normal_Item_When_A_Day_Passes_Then_The_Quality_Value_Decreases_By_1()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Normal Item", SellIn = 5, Quality = 10 } };
            GildedRose app = new GildedRose(Items, new ItemStrategyFactory());
            app.UpdateQuality();
            Assert.Equal(9, Items[0].Quality);
        }

        [Fact]
        public void Given_A_Normal_Item_When_A_Day_Passes_And_The_Sellin_Value_Is_0_Then_The_Quality_Value_Decreases_By_2()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Normal Item", SellIn = 0, Quality = 10 } };
            GildedRose app = new GildedRose(Items, new ItemStrategyFactory());
            app.UpdateQuality();
            Assert.Equal(8, Items[0].Quality);
        }

        [Fact]
        public void Given_A_Normal_Item_When_A_Day_Passes_And_The_Sellin_Value_Is_0_Then_The_Sellin_Value_Decreases_By_1()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Normal Item", SellIn = 0, Quality = 10 } };
            GildedRose app = new GildedRose(Items, new ItemStrategyFactory());
            app.UpdateQuality();
            Assert.Equal(-1, Items[0].SellIn);
        }

        [Fact]
        public void Given_A_Normal_Item_When_A_Day_Passes_And_Quality_Is_0_The_Quality_Should_Remain_At_0()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Normal Item", SellIn = 5, Quality = 0 } };
            GildedRose app = new GildedRose(Items, new ItemStrategyFactory());
            app.UpdateQuality();
            Assert.Equal(0, Items[0].Quality);
        }

        [Fact]
        public void Given_The_Item_Is_Aged_Brie_When_A_Day_Passes_And_Quality_Is_50_The_Quality_Should_Remain_At_50()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 5, Quality = 50 } };
            GildedRose app = new GildedRose(Items, new ItemStrategyFactory());
            app.UpdateQuality();
            Assert.Equal(50, Items[0].Quality);
        }

       [Fact]
        public void Given_The_Item_Is_Aged_Brie_When_A_Day_Passes_The_Sellin_Value_Should_Decrease_By_1()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 5, Quality = 10 } };
            GildedRose app = new GildedRose(Items, new ItemStrategyFactory());
            app.UpdateQuality();
            Assert.Equal(4, Items[0].SellIn);
        }

        [Fact]
        public void Given_The_Item_Is_Aged_Brie_When_A_Day_Passes_The_Quality_Value_Should_Increase_By_1()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 5, Quality = 10 } };
            GildedRose app = new GildedRose(Items, new ItemStrategyFactory());
            app.UpdateQuality();
            Assert.Equal(11, Items[0].Quality);
        }

        [Fact]
        public void Given_The_Item_Is_Sulfuras_When_A_Day_Passes_The_Quality_Value_Should_Stay_The_Same()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 5, Quality = 80 } };
            GildedRose app = new GildedRose(Items, new ItemStrategyFactory());
            app.UpdateQuality();
            Assert.Equal(5, Items[0].SellIn);
        }

        [Fact]
        public void Given_The_Item_Is_Sulfuras_When_A_Day_Passes_The_Sellin_Value_Should_Stay_The_Same()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 5, Quality = 80 } };
            GildedRose app = new GildedRose(Items, new ItemStrategyFactory());
            app.UpdateQuality();
            Assert.Equal(80, Items[0].Quality);
        }

        [Fact]
        public void Given_The_Item_Is_Backstage_Passes_When_A_Day_Passes_And_Quality_Is_50_The_Quality_Should_Remain_At_50()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 50 } };
            GildedRose app = new GildedRose(Items, new ItemStrategyFactory());
            app.UpdateQuality();
            Assert.Equal(50, Items[0].Quality);
        }

        [Fact]
        public void Given_The_Item_Is_Backstage_Passes_When_A_Day_Passes_And_The_Sellin_Value_Is_Over_10_The_Quality_Value_Should_Increase_By_1()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 20 } };
            GildedRose app = new GildedRose(Items, new ItemStrategyFactory());
            app.UpdateQuality();
            Assert.Equal(21, Items[0].Quality);
        }

        [Fact]
        public void Given_The_Item_Is_Backstage_Passes_When_A_Day_Passes_And_The_Sellin_Value_Is_Over_10_The_Sellin_Value_Should_Decrease_By_1()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 20 } };
            GildedRose app = new GildedRose(Items, new ItemStrategyFactory());
            app.UpdateQuality();
            Assert.Equal(10, Items[0].SellIn);
        }

        [Fact]
        public void Given_The_Item_Is_Backstage_Passes_When_A_Day_Passes_And_The_Sellin_Value_Is_10_0r_Less_The_Quality_Value_Should_Increase_By_2()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 20 } };
            GildedRose app = new GildedRose(Items, new ItemStrategyFactory());
            app.UpdateQuality();
            Assert.Equal(22, Items[0].Quality);
        }

        [Fact]
        public void Given_The_Item_Is_Backstage_Passes_When_A_Day_Passes_And_The_Sellin_Value_Is_10_Or_Less_The_Sellin_Value_Should_Decrease_By_1()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 20 } };
            GildedRose app = new GildedRose(Items, new ItemStrategyFactory());
            app.UpdateQuality();
            Assert.Equal(9, Items[0].SellIn);
        }

        [Fact]
        public void Given_The_Item_Is_Backstage_Passes_When_A_Day_Passes_And_The_Sellin_Value_Is_5_Or_Less_The_Quality_Value_Should_Increase_By_3()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 20 } };
            GildedRose app = new GildedRose(Items, new ItemStrategyFactory());
            app.UpdateQuality();
            Assert.Equal(23, Items[0].Quality);
        }

        [Fact]
        public void Given_The_Item_Is_Backstage_Passes_When_A_Day_Passes_And_The_Sellin_Value_Is_5_Or_Less_The_Sellin_Value_Should_Decrease_By_1()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 20 } };
            GildedRose app = new GildedRose(Items, new ItemStrategyFactory());
            app.UpdateQuality();
            Assert.Equal(4, Items[0].SellIn);
        }


        [Fact]
        public void Given_The_Item_Is_Backstage_Passes_When_A_Day_Passes_And_The_Sellin_Value_Is_Less_Than_0_The_Quality_Value_Should_Decrease_To_0()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = -1, Quality = 20 } };
            GildedRose app = new GildedRose(Items, new ItemStrategyFactory());
            app.UpdateQuality();
            Assert.Equal(0, Items[0].Quality);
        }

        [Fact]
        public void Given_The_Item_Is_Backstage_Passes_When_A_Day_Passes_And_The_Sellin_Value_Is_0_The_Sellin_Value_Should_Decrease_By_1()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 20 } };
            GildedRose app = new GildedRose(Items, new ItemStrategyFactory());
            app.UpdateQuality();
            Assert.Equal(-1, Items[0].SellIn);
        }

        [Fact]
        public void Given_The_Item_Is_A_Conjured_Item_When_A_Day_Passes_The_Quality_Value_Should_Decrease_By_2()
        {
            IList < Item > Items = new List<Item> { new Item { Name = "Conjured", SellIn = 5, Quality = 10 } };
            GildedRose app = new GildedRose(Items, new ItemStrategyFactory());
            app.UpdateQuality();
            Assert.Equal(8, Items[0].Quality);
        }

        [Fact]
        public void Given_The_Item_Is_A_Conjured_Item_When_A_Day_Passes_The_Sellin_Value_Should_Decrease_By_1()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured", SellIn = 5, Quality = 10 } };
            GildedRose app = new GildedRose(Items, new ItemStrategyFactory());
            app.UpdateQuality();
            Assert.Equal(4, Items[0].SellIn);
        }
    }
}
