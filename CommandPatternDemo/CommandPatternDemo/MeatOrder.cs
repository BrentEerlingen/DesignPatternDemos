using System;
namespace CommandPatternDemo
{
    public class MeatOrder: Order
    {
        public MeatOrder()
        {
        }

        public void Cook()
        {
            Console.WriteLine("Grilling the meat");
        }
    }
}
