using System.Text;

namespace FactoryMethod.AbstractProduct
{
    /// <summary>
    /// The AbstractProduct class
    /// </summary>
    internal abstract class Page
    {
        private StringBuilder _text;
        public string Text
        {
            get => _text.ToString();
            protected set => _text = new StringBuilder(value);
        }

        protected Page()
        {
            Text = "";
        }
    }
}
