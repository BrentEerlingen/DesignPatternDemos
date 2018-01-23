using System;
namespace CommandPatternDemo
{
    public class VeggieOrder: Order
    {
        public VeggieOrder()
        {
        }

        public void Cook(){
            Console.WriteLine("Steaming the vegetables");

        }
    }
}
