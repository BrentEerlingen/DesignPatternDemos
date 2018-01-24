using System;

namespace ObserverPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var auc = new Auctioneer(10);

            new DoubleBidder(auc);
            new TripleBidder(auc);

            Console.WriteLine("The startingprice is 10");
            auc.InvokeBidders();
        }
    }
}
