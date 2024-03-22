using GildedRoseKata;
using GildedRoseKata.Constants;
using JetBrains.Annotations;
using System.Collections.Generic;

namespace GildedRoseTests.Setup
{
    internal delegate void AssertionCall(Item item);

    internal class TestBed
    {
        private List<Item> items;
        private AssertionCall? _itemAssertion;

        public TestBed()
        {
            items = new List<Item>();
        }

        internal void Run()
        {
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            _itemAssertion.Invoke(items[0]);
        }

        internal TestBed WithItem(string name, int sellIn, int quality)
        {
            items.Add(new Item { Name = name, SellIn = sellIn, Quality = quality });
            return this;
        }

        internal TestBed WithNormalItem(int sellIn, int quality)
        {
            WithItem(ItemNames.NormalItem, sellIn, quality);
            return this;
        }

        internal TestBed WithAgedBrie(int sellIn, int quality)
        {
            WithItem(ItemNames.AgedBrie, sellIn, quality);
            return this;
        }

        internal TestBed WithSulfuras(int sellIn, int quality)
        {
            WithItem(ItemNames.Sulfuras, sellIn, quality);
            return this;
        }

        internal TestBed WithBackstagePass(int sellIn, int quality)
        {
            WithItem(ItemNames.BackstagePasses, sellIn, quality);
            return this;
        }

        internal TestBed WithConjuredManaCake(int sellIn, int quality)
        {
            WithItem(ItemNames.ConjuredManaCake, sellIn, quality);
            return this;
        }

        [AssertionMethod]
        public TestBed WithAssertion(AssertionCall assertions)
        {
            _itemAssertion = item =>
            {
                assertions(item);
            };

            return this;
        }
    }
}
