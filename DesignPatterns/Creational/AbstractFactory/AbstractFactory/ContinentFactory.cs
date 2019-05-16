using AbstractFactory.AbstractProduct;

namespace AbstractFactory.AbstractFactory
{
    /// <summary>
    /// The abstract factory class
    /// </summary>
    internal abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }
}