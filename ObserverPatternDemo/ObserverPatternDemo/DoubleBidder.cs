using System;
namespace ObserverPatternDemo
{
    public class DoubleBidder: Bidder
    {
        Auctioneer auc;

        public DoubleBidder(Auctioneer auc)
        {
            this.auc = auc;
            auc.Attach(this);
        }

        public void Bid(){
            int state = auc.GetState();
            int newState = state * 2;
            Console.WriteLine("I bid " + newState);
            auc.SetState(newState);
        }
    }
}
