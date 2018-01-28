using System;

namespace Decorator
{
    /// <summary>
    /// The 'Decorator' abstract class
    /// maintains a reference to a Component object (LibraryItem) and defines an interface that conforms to Component's interface.
    /// </summary>
    public abstract class Decorator : LibraryItem
    {
        protected LibraryItem libraryItem;

        protected Decorator(LibraryItem libraryItem)
        {
            this.libraryItem = libraryItem;
        }

        public override void Display()
        {
            libraryItem.Display();
        }
    }
}