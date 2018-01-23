using System;

namespace CommandPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var w1 = new Waitress();

            var meatOrder = new MeatOrder();
            var veggiePrder = new VeggieOrder();

            w1.TakeOrder(meatOrder);
            w1.TakeOrder(veggiePrder);

            w1.PlaceOrder();
        }
    }
}
