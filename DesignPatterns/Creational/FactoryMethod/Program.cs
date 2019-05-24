using System;
using System.Collections.Generic;
using FactoryMethod.AbstractCreator;
using FactoryMethod.ConcreteCreator;

namespace FactoryMethod
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var documents = new List<Document> {new Resume(), new Report()};
            foreach (var doc in documents)
            {
                doc.CreatePages();
                foreach (var page in doc.Pages)
                {
                    Console.WriteLine($"{doc.Type}: {page.Text}");
                }
            }
        }
    }
}
