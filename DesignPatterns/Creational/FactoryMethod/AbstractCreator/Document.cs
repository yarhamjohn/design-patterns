using System.Collections.Generic;
using FactoryMethod.AbstractProduct;

namespace FactoryMethod.AbstractCreator
{
    /// <summary>
    /// The AbstractCreator class
    /// </summary>
    internal abstract class Document
    {
        protected internal readonly List<Page> Pages;
        protected internal string Type;

        protected Document() => Pages = new List<Page>();

        protected internal abstract void CreatePages();
    }
}
