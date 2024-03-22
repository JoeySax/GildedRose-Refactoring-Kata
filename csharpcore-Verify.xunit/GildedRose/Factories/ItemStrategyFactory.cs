using GildedRoseKata.Constants;
using GildedRoseKata.Factories.Interfaces;
using GildedRoseKata.UpdateStrategies;
using GildedRoseKata.UpdateStrategies.Interfaces;
using System.Collections.Generic;

namespace GildedRoseKata.Factories
{
    public class ItemStrategyFactory : IItemStrategyFactory
    {
        private readonly Dictionary<string, IItemStrategy> itemStrategies;

        public ItemStrategyFactory()
        {
            itemStrategies = new Dictionary<string, IItemStrategy>
            {
                { ItemNames.AgedBrie, new AgedBrieStrategy() },
                { ItemNames.BackstagePasses, new BackstagePassesStrategy() },
                { ItemNames.Sulfuras, new LegendaryItemStrategy() },
                { ItemNames.ConjuredManaCake, new ConjuredItemStrategy() }
            };
        }

        public IItemStrategy Create(string name)
        {
            if (itemStrategies.TryGetValue(name, out IItemStrategy strategy))
            {
                return strategy;
            }

            return new NormalItemStrategy();
        }
    }
}
