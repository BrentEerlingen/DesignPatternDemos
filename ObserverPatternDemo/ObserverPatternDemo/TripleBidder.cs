using System;
namespace ObserverPatternDemo
{
    public class TripleBidder: Bidder
    {
        Auctioneer auc;

        public TripleBidder(Auctioneer auc)
        {
            this.auc = auc;
            auc.Attach(this);
        }

        public void Bid()
        {
            int state = auc.GetState();
            int newState = state * 3;
            Console.WriteLine("I bid " + newState);
            auc.SetState(newState);
        }
    }
}
