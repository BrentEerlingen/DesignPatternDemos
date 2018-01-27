using System;
namespace CommandPatternPractice.Before
{
    public class Logger
    {
        public Logger()
        {
            
        }

        public void Log(string type){
            switch (type){
                case "Console":
                    Console.WriteLine("Ik log");
                    break;
                case "File":
                    Console.WriteLine("Ik log een file");
                    break;
            }

        }
    }
}
