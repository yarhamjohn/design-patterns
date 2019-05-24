using Builder.AbstractBuilder;
using Builder.Product;

namespace Builder.ConcreteBuilder
{
    /// <summary>
    /// The ConcreteBuilder class
    /// </summary>
    internal class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            Vehicle = new Vehicle("Car");
        }

        public override void BuildFrame()
        {
            Vehicle.Frame = "Car Frame";
        }

        public override void BuildEngine()
        {
            Vehicle.Engine = "2500 cc";
        }

        public override void BuildWheels()
        {
            Vehicle.Wheels = "4";
        }

        public override void BuildDoors()
        {
            Vehicle.Doors = "4";
        }
    }
}
