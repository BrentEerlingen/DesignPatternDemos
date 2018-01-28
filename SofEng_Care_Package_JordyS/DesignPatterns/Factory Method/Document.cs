using System.Collections.Generic;

namespace Factory_Method
{
    /// <summary>
    /// The 'Creator' abstract class
    /// declares the factory method, which returns an object of type Product (Page). Creator may also define a default
    /// implementation of the factory method that returns a default ConcreteProduct (SkillsPage, ...) object.
    /// may call the factory method to create a Product (Page) object.
    /// </summary>
    public abstract class Document
    {
        private List<Page> _pages = new List<Page>();

        // Calls abstract Factory method
        protected Document()
        {
            this.CreatePages();
        }

        public List<Page> Pages
        {
            get { return _pages; }
        }
        
        // Factory Method
        public abstract void CreatePages();
    }
}