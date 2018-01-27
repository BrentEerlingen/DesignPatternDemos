using System;
using System.Collections.Generic;
namespace CommandPatternPractice.After
{
    public class Invoker
    {
        private List<ILogger> loggers;

        public Invoker()
        {
            
        }

        public void AddLogger(ILogger logger){
            loggers.Add(logger);
        }

        public void InvokeLogger(){
            foreach(ILogger logger in loggers){
                logger.Log();
            }
        }
    }
}
