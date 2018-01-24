using System;

namespace SingletonPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // This will give you a Compile Time Error: the constructor is not visible in this class
            // var potus = new Potus();

            var potus = Potus.GetPotus();

            potus.RandomTweet();
        }
    }
}
