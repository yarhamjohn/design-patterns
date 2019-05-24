using System.Collections.Generic;
using Builder.AbstractBuilder;
using Builder.ConcreteBuilder;
using Builder.Director;

namespace Builder
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            VehicleBuilder builder;
            var shop = new Shop();

            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
        }
    }
}
