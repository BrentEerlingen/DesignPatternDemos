using System.Collections.Generic;

namespace Strategy
{
    /// <summary>
    /// The 'Strategy' abstract class
    /// declares an interface common to all supported algorithms. Context (SortedList) uses this interface to call the algorithm defined by a ConcreteStrategy
    /// </summary>
    public abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }
}