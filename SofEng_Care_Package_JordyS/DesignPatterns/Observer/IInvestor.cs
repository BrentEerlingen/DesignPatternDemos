namespace Observer
{
    /// <summary>
    /// The 'Observer' interface
    /// defines an updating interface for objects that should be notified of changes in a subject.
    /// </summary>
    public interface IInvestor
    {
        void Update(Stock stock);
    }
}