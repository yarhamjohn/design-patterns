using Builder.AbstractBuilder;
using Builder.Product;

namespace Builder.ConcreteBuilder
{
    /// <summary>
    /// The ConcreteBuilder class
    /// </summary>
    internal class ScooterBuilder : VehicleBuilder
    {
        public ScooterBuilder()
        {
            Vehicle = new Vehicle("Scooter");
        }

        public override void BuildFrame()
        {
            Vehicle.Frame = "Scooter Frame";
        }

        public override void BuildEngine()
        {
            Vehicle.Engine = "50 cc";
        }

        public override void BuildWheels()
        {
            Vehicle.Wheels = "2";
        }

        public override void BuildDoors()
        {
            Vehicle.Doors = "0";
        }
    }
}
