using Builder.AbstractBuilder;
using Builder.Product;

namespace Builder.ConcreteBuilder
{
    /// <summary>
    /// The ConcreteBuilder class
    /// </summary>
    internal class MotorCycleBuilder : VehicleBuilder
    {
        public MotorCycleBuilder()
        {
            Vehicle = new Vehicle("MotorCycle");
        }

        public override void BuildFrame()
        {
            Vehicle.Frame = "MotorCycle Frame";
        }

        public override void BuildEngine()
        {
            Vehicle.Engine = "500 cc";
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
