using Builder.Product;

namespace Builder.AbstractBuilder
{
    /// <summary>
    /// The AbstractBuilder class
    /// </summary>
    internal abstract class VehicleBuilder
    {
        protected internal Vehicle Vehicle { get; protected set; }

        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }
}
