using System;
using System.Collections.Generic;
namespace ObserverPatternDemo
{
    public class Auctioneer
    {
        private List<Bidder> bidders = new List<Bidder>();
        private int state;
        private int index = 0;
        
        public Auctioneer(int startPrice)
        {
            state = startPrice;
        }

        public void Attach(Bidder bidder){
            bidders.Add(bidder);
        }

        public int GetState(){
            return state;
        }

        public void SetState(int state){
            if (state > this.state){
                this.state = state; 
                Console.WriteLine("The new price is " + state);
            }
        }

        public void InvokeBidders(){
            foreach (Bidder bidder in bidders)
            {
                bidder.Bid();
            }
        }
    }
}
