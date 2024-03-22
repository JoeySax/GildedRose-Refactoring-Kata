using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        [Fact]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal("fixme", Items[0].Name);
        }

        [Fact]
        public void Given_A_Normal_Item_When_A_Day_Passes_Then_The_SellIn_Value_Decreases_By_1()
        {
            //TODO ADD TEST
        }

        [Fact]
        public void Given_A_Normal_Item_When_A_Day_Passes_Then_The_Quality_Value_Decreases_By_1()
        {
            //TODO ADD TEST
        }

        [Fact]
        public void Given_A_Normal_Item_When_A_Day_Passes_And_The_Sellin_Value_Is_0_Then_The_Quality_Value_Decreases_By_2()
        {
            //TODO ADD TEST
        }

        [Fact]
        public void Given_A_Normal_Item_When_A_Day_Passes_And_The_Sellin_Value_Is_0_Then_The_Sellin_Value_Decreases_By_1()
        {
            //TODO ADD TEST
        }

        [Fact]
        public void Given_A_Normal_Item_When_A_Day_Passes_And_Quality_Is_0_The_Quality_Should_Remain_At_0()
        {
            //TODO ADD TEST
        }

        [Fact]
        public void Given_A_Normal_Item_When_A_Day_Passes_And_Quality_Is_50_The_Quality_Should_Remain_At_50()
        {
            //TODO ADD TEST
        }

       [Fact]
        public void Given_The_Item_Is_Aged_Brie_When_A_Day_Passes_The_Sellin_Value_Should_Decrease_By_1()
        {
            //TODO ADD TEST
        }

        [Fact]
        public void Given_The_Item_Is_Aged_Brie_When_A_Day_Passes_The_Quality_Value_Should_Increase_By_1()
        {
            //TODO ADD TEST
        }

        [Fact]
        public void Given_The_Item_Is_Sulfuras_When_A_Day_Passes_The_Quality_Value_Should_Stay_The_Same()
        {
            //TODO ADD TEST
        }

        [Fact]
        public void Given_The_Item_Is_Sulfuras_When_A_Day_Passes_The_Sellin_Value_Should_Stay_The_Same()
        {
            //TODO ADD TEST
        }

        [Fact]
        public void Given_The_Item_Is_Backstage_Passes_When_A_Day_Passes_And_The_Sellin_Value_Is_Over_10_The_Quality_Value_Should_Increase_By_1()
        {
            //TODO ADD TEST
        }

        [Fact]
        public void Given_The_Item_Is_Backstage_Passes_When_A_Day_Passes_And_The_Sellin_Value_Is_Over_10_The_Sellin_Value_Should_Decrease_By_1()
        {
            //TODO ADD TEST
        }

        [Fact]
        public void Given_The_Item_Is_Backstage_Passes_When_A_Day_Passes_And_The_Sellin_Value_Is_10_0r_Less_The_Quality_Value_Should_Increase_By_2()
        {
            //TODO ADD TEST
        }

        [Fact]
        public void Given_The_Item_Is_Backstage_Passes_When_A_Day_Passes_And_The_Sellin_Value_Is_10_Or_Less_The_Sellin_Value_Should_Decrease_By_1()
        {
            //TODO ADD TEST
        }

        [Fact]
        public void Given_The_Item_Is_Backstage_Passes_When_A_Day_Passes_And_The_Sellin_Value_Is_5_Or_Less_The_Quality_Value_Should_Increase_By_3()
        {
            //TODO ADD TEST
        }

        [Fact]
        public void Given_The_Item_Is_Backstage_Passes_When_A_Day_Passes_And_The_Sellin_Value_Is_5_Or_Less_The_Sellin_Value_Should_Decrease_By_1()
        {
            //TODO ADD TEST
        }


        [Fact]
        public void Given_The_Item_Is_Backstage_Passes_When_A_Day_Passes_And_The_Sellin_Value_Is_0_The_Quality_Value_Should_Decrease_To_0()
        {
            //TODO ADD TEST
        }

        [Fact]
        public void Given_The_Item_Is_Backstage_Passes_When_A_Day_Passes_And_The_Sellin_Value_Is_0_The_Sellin_Value_Should_Decrease_By_1()
        {
            //TODO ADD TEST
        }

        [Fact]
        public void Given_The_Item_Is_A_Conjured_Item_When_A_Day_Passes_The_Quality_Value_Should_Decrease_By_2()
        {
            //TODO ADD TEST
        }

        [Fact]
        public void Given_The_Item_Is_A_Conjured_Item_When_A_Day_Passes_The_Sellin_Value_Should_Decrease_By_1()
        {
            //TODO ADD TEST
        }
    }
}
