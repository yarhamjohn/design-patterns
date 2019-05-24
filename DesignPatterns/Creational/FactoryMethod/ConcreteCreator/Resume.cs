using FactoryMethod.AbstractCreator;
using FactoryMethod.ConcreteProduct;

namespace FactoryMethod.ConcreteCreator
{
    /// <summary>
    /// The ConcreteCreator class
    /// </summary>
    internal class Resume : Document
    {
        public Resume()
        {
            Type = "Resume";
        }

        protected internal override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new SummaryPage());
        }
    }
}
