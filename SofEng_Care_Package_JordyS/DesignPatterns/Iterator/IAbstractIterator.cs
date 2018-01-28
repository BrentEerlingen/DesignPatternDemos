namespace Iterator
{
    /// <summary>
    /// The 'Iterator' interface
    /// defines an interface for accessing and traversing elements.
    /// </summary>
    interface IAbstractIterator
    {
        Item First();
        Item Next();
        bool IsDone { get; }
        Item CurrentItem { get; }
    }
}