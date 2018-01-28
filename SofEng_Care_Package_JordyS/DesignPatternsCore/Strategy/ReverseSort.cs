using System;
using System.Collections.Generic;

namespace Strategy
{
    /// <summary>
    /// A 'ConcreteStrategy' class
    /// implements the algorithm using the Strategy interface (SortStrategy)
    /// </summary>
    public class ReverseSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Reverse();
            Console.WriteLine("ReverseSorted list ");
        }
    }
}