using System.Collections;

namespace Iterator
{
    /// <summary>
    /// The 'ConcreteAggregate' class
    /// implements the Iterator creation interface to return an instance of the proper ConcreteIterator
    /// </summary>
    public class Collection : IAbstractCollection
    {
        private ArrayList _items = new ArrayList();

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        // Gets item count

        public int Count
        {
            get { return _items.Count; }
        }

        // Indexer

        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }
    }
}