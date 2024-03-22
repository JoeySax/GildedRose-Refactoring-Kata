using GildedRoseKata.UpdateStrategies;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                switch (Items[i].Name)
                {
                    case "Aged Brie":
                        new AgedBrieStrategy().UpdateItem(Items[i]);
                        break;
                    case "Backstage passes to a TAFKAL80ETC concert":
                        new BackstagePassesStrategy().UpdateItem(Items[i]);
                        break;
                    case "Sulfuras, Hand of Ragnaros":
                        new LegendaryItemStrategy().UpdateItem(Items[i]);
                        break;
                    default:
                        new NormalItemStrategy().UpdateItem(Items[i]);
                        break;
                }
            }
        }
    }
}
