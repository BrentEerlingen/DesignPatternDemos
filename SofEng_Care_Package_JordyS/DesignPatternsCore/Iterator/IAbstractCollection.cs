namespace Iterator
{
    /// <summary>
    /// The 'Aggregate' interface
    /// defines an interface for creating an Iterator object
    /// </summary>
    public interface IAbstractCollection
    {
        Iterator CreateIterator();
    }
}