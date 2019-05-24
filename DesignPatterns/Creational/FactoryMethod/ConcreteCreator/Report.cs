using FactoryMethod.AbstractCreator;
using FactoryMethod.ConcreteProduct;

namespace FactoryMethod.ConcreteCreator
{
    /// <summary>
    /// The ConcreteCreator class
    /// </summary>
    internal class Report : Document
    {
        public Report()
        {
            Type = "Report";
        }

        protected internal override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new SummaryPage());
        }
    }
}
