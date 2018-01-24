using System;
namespace SingletonPatternDemo
{
    public class Potus
    {
        private static Potus potus = new Potus();

        private Potus()
        {
        }

        public static Potus GetPotus()
        {
            return potus;
        }

        public void RandomTweet(){
            Console.WriteLine("This is fake news!");
        }
    }
}
