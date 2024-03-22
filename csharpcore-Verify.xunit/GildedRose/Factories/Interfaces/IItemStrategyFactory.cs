using GildedRoseKata.UpdateStrategies.Interfaces;

namespace GildedRoseKata.Factories.Interfaces
{
    public interface IItemStrategyFactory
    {
        IUpdateItemStrategy Create(string name);
    }
}
