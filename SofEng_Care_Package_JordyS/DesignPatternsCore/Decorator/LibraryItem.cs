namespace Decorator
{
    /// <summary>
    /// The 'Component' abstract class
    /// defines the interface for objects that can have responsibilities added to them dynamically.
    /// </summary>
    public abstract class LibraryItem
    {
        private int _numCopies;

        public int NumCopies
        {
            get { return _numCopies; }
            set { _numCopies = value; }
        }

        public abstract void Display();
    }
}