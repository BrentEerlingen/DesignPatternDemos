using System;
using System.Collections.Generic;
using System.Linq;

namespace Strategy
{
    /// <summary>
    /// A 'ConcreteStrategy' class
    /// implements the algorithm using the Strategy interface (SortStrategy)
    /// </summary>
    public class ShuffleSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            var rnd = new Random();
            list = list.OrderBy(x => rnd.Next()).ToList();

            Console.WriteLine("ShuffleSorted list ");
        }
    }
}