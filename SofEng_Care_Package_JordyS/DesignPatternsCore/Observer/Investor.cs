using System;

namespace Observer
{
    /// <summary>
    /// The 'ConcreteObserver' class
    /// maintains a reference to a ConcreteSubject object (IBM)
    /// stores state that should stay consistent with the subject's
    /// implements the Observer (IInvestor) updating interface to keep its state consistent with the subject's
    /// </summary>
    public class Investor : IInvestor
    {
        private string _name;
        private Stock _stock;

        public Investor(string name)
        {
            this._name = name;
        }


        public void Update(Stock stock)
        {
            Console.WriteLine("Notified {0} of {1}'s " +"change to {2:C}", _name, stock.Symbol, stock.Price);
        }

        public Stock Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }
    }
}