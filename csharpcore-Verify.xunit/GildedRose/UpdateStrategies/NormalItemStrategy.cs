using GildedRoseKata.UpdateStrategies.Interfaces;
using System;

namespace GildedRoseKata.UpdateStrategies
{
    public class NormalItemStrategy : IItemStrategy
    {
        public void UpdateItem(Item item)
        {
            item.SellIn -= 1;

            if (item.SellIn >= 0)
            {
                item.Quality = Math.Max(0, item.Quality - 1);
            }
            else
            {
                item.Quality = Math.Max(0, item.Quality - 2);
            }
        }
    }
}
