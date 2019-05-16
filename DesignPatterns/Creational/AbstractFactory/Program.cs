using AbstractFactory.AbstractFactory;
using AbstractFactory.Client;
using AbstractFactory.ConcreteFactory;

namespace AbstractFactory
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld africanWorld = new AnimalWorld(africa);
            africanWorld.RunFoodChain();

            ContinentFactory america = new AmericaFactory();
            AnimalWorld americanWorld = new AnimalWorld(america);
            americanWorld.RunFoodChain();
        }
    }
}
