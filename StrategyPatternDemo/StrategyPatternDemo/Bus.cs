using System;
namespace StrategyPatternDemo
{
    public class Bus: Strategy
    {
        public Bus()
        {
        }

        public void Move()
        {
            Console.WriteLine("Car:");
            Console.WriteLine("\t The cost is 10€");
            Console.WriteLine("\t The time to the airpot is 4h");
        }
    }
}
