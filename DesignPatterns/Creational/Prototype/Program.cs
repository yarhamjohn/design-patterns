using System;
using System.Collections.Generic;
using Prototype.AbstractPrototype;
using Prototype.ConcretePrototype;

namespace Prototype
{
    internal static class Program
    {
        /// <summary>
        /// The Client class
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            var colorManager = new ColorManager
            {
                ["red"] = new Color(255, 0, 0),
                ["green"] = new Color(0, 255, 0),
                ["blue"] = new Color(0, 0, 255)
            };

            var clonedRed = colorManager["red"].Clone();
            clonedRed.Red = 200;
            var clonedGreen = colorManager["green"].Clone();
            clonedGreen.Green = 200;
            var clonedBlue = colorManager["blue"].Clone();
            clonedBlue.Blue = 200;

            Console.WriteLine($"Red RGB         : {colorManager["red"]}");
            Console.WriteLine($"Cloned Red RGB  : {clonedRed}");
            Console.WriteLine($"Green RGB       : {colorManager["green"]}");
            Console.WriteLine($"Cloned Green RGB: {clonedGreen}");
            Console.WriteLine($"Blue RGB        : {colorManager["blue"]}");
            Console.WriteLine($"Cloned Blue RGB : {clonedBlue}");
        }

        private class ColorManager
        {
            private readonly Dictionary<string, ColorPrototype> _colors = new Dictionary<string, ColorPrototype>();

            public ColorPrototype this[string key]
            {
                get => _colors[key];
                set => _colors[key] = value;
            }
        }

    }
}
