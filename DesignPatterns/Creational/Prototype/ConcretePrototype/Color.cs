using System;
using Prototype.AbstractPrototype;

namespace Prototype.ConcretePrototype
{
    /// <summary>
    /// The ConcretePrototype class
    /// </summary>
    internal class Color : ColorPrototype
    {
        protected internal sealed override int Red { protected get; set; }
        protected internal sealed override int Green { protected get; set; }
        protected internal sealed override int Blue { protected get; set; }

        public Color(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        protected internal override ColorPrototype Clone()
        {
            Console.WriteLine($"Cloning color RGB: {Red},{Green},{Blue}");

            // Creates a shallow copy only. To do a deep clone, MemberwiseClone() should be called on each object recursively
            return MemberwiseClone() as ColorPrototype;
        }
    }
}
