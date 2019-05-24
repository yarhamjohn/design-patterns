using Builder.AbstractBuilder;

namespace Builder.Director
{
    /// <summary>
    /// The Director class
    /// </summary>
    internal class Shop
    {
        public void Construct(VehicleBuilder builder)
        {
            builder.BuildFrame();
            builder.BuildEngine();
            builder.BuildWheels();
            builder.BuildDoors();
        }
    }
}
