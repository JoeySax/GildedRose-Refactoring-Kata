using GildedRoseKata.UpdateStrategies.Interfaces;
using System;

namespace GildedRoseKata.UpdateStrategies
{
    public class BackstagePassesStrategy : IUpdateItemStrategy
    {
        public void UpdateItem(Item item)
        {
            item.SellIn -= 1;

            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
            else if (item.SellIn < 5)
            {
                item.Quality += 3;
            }
            else if (item.SellIn < 10)
            {
                item.Quality += 2;
            }
            else
            {
                item.Quality += 1;
            }

            item.Quality = Math.Min(50, item.Quality);
        }
    }
}
