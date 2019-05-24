using System;

namespace Builder.Product
{
    /// <summary>
    /// The Product class
    /// </summary>
    internal class Vehicle
    {
        private readonly string _vehicleType;
        public string Frame { private get; set; }
        public string Doors { private get; set; }
        public string Wheels { private get; set; }
        public string Engine { private get; set; }

        public Vehicle(string vehicleType)
        {
            _vehicleType = vehicleType;
        }

        public void Show()
        {
            Console.WriteLine("\n-----------------------------\n");
            Console.WriteLine($"Vehicle Type: {_vehicleType}");
            Console.WriteLine($"Frame: {Frame}");
            Console.WriteLine($"Engine: {Engine}");
            Console.WriteLine($"Wheels: {Wheels}");
            Console.WriteLine($"Doors: {Doors}");
        }
    }
}
