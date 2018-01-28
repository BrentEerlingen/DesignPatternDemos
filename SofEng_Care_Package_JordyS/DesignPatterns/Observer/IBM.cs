namespace Observer
{
    /// <summary>
    /// The 'ConcreteSubject' class
    /// stores state of interest to ConcreteObserver (Investor)
    /// sends a notification to its observers (IInvestor) when its state changes
    /// </summary>
    public class IBM : Stock
    {
        public IBM(string symbol, double price) 
            : base(symbol, price)
        {
            
        }
    }
}