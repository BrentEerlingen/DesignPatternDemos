using System;

namespace Strategy
{
    /// <summary>
    /// Define a family of algorithms, encapsulate each one, and make them interchangeable.
    /// Strategy lets the algorithm vary independently from clients that use it.
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Two contexts following diffrent strategies
            SortedList studentRecords = new SortedList();

            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ReverseSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ShuffleSort());
            studentRecords.Sort();

            // Wait for user

            Console.ReadKey();
        }
//        // Structural code
//        static void Main()
//        {
//            Context context;
// 
//            // Three contexts following different strategies
//
//            context = new Context(new ConcreteStrategyA());
//            context.ContextInterface();
// 
//            context = new Context(new ConcreteStrategyB());
//            context.ContextInterface();
// 
//            context = new Context(new ConcreteStrategyC());
//            context.ContextInterface();
// 
//            // Wait for user
//
//            Console.ReadKey();
//        }
//    }
// 
//    /// <summary>
//
//    /// The 'Strategy' abstract class
//
//    /// </summary>
//
//    abstract class Strategy
//
//    {
//        public abstract void AlgorithmInterface();
//    }
// 
//    /// <summary>
//
//    /// A 'ConcreteStrategy' class
//
//    /// </summary>
//
//    class ConcreteStrategyA : Strategy
//
//    {
//        public override void AlgorithmInterface()
//        {
//            Console.WriteLine(
//                "Called ConcreteStrategyA.AlgorithmInterface()");
//        }
//    }
// 
//    /// <summary>
//
//    /// A 'ConcreteStrategy' class
//
//    /// </summary>
//
//    class ConcreteStrategyB : Strategy
//
//    {
//        public override void AlgorithmInterface()
//        {
//            Console.WriteLine(
//                "Called ConcreteStrategyB.AlgorithmInterface()");
//        }
//    }
// 
//    /// <summary>
//
//    /// A 'ConcreteStrategy' class
//
//    /// </summary>
//
//    class ConcreteStrategyC : Strategy
//
//    {
//        public override void AlgorithmInterface()
//        {
//            Console.WriteLine(
//                "Called ConcreteStrategyC.AlgorithmInterface()");
//        }
//    }
// 
//    /// <summary>
//
//    /// The 'Context' class
//
//    /// </summary>
//
//    class Context
//
//    {
//        private Strategy _strategy;
// 
//        // Constructor
//
//        public Context(Strategy strategy)
//        {
//            this._strategy = strategy;
//        }
// 
//        public void ContextInterface()
//        {
//            _strategy.AlgorithmInterface();
//        }
//    }
//}
    }
}