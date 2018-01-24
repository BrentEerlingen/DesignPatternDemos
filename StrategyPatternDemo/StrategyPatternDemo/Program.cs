using System;

namespace StrategyPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new Car());        
            context.ExecuteStrategy();

            context = new Context(new Bus());        
            context.ExecuteStrategy();

        }
    }
}
