using System;
namespace StrategyPatternDemo
{
    public class Car: Strategy
    {
        public Car()
        {
        }

        public void Move(){
            Console.WriteLine("Car:");
            Console.WriteLine("\t The cost is 40€");
            Console.WriteLine("\t The time to the airpot is 1h");
        }
    }
}
