using AbstractFactory.AbstractFactory;
using AbstractFactory.AbstractProduct;

namespace AbstractFactory.Client
{
    /// <summary>
    /// The client class
    /// </summary>
    internal class AnimalWorld
    {
        private readonly Carnivore _carnivore;
        private readonly Herbivore _herbivore;

        public AnimalWorld(ContinentFactory factory)
        {
            _carnivore = factory.CreateCarnivore();
            _herbivore = factory.CreateHerbivore();
        }

        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}
