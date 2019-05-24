namespace Prototype.AbstractPrototype
{
    /// <summary>
    /// The AbstractPrototype class
    /// </summary>
    internal abstract class ColorPrototype
    {
        protected internal abstract int Red { protected get; set; }
        protected internal abstract int Green { protected get; set; }
        protected internal abstract int Blue { protected get; set; }

        protected internal abstract ColorPrototype Clone();

        public override string ToString()
        {
            return $"{Red}, {Green}, {Blue}";
        }
    }
}
