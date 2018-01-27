using System;
namespace CommandPatternPractice.After
{
    public class ConsoleLogger: ILogger
    {
        public ConsoleLogger()
        {
        }

        public void Log(){
            Console.WriteLine("Ik log");
        }
    }
}
