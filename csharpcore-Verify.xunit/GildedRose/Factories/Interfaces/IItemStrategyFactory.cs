using GildedRoseKata.UpdateStrategies.Interfaces;

namespace GildedRoseKata.Factories.Interfaces
{
    public interface IItemStrategyFactory
    {
        IItemStrategy Create(string name);
    }
}
