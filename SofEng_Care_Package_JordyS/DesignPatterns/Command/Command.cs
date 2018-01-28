namespace Command
{
    /// <summary>
    /// The 'Command' abstract class
    /// declares an interface for executing an operation
    /// </summary>
    public abstract class Command
    {
        public abstract void Execute();
        public abstract void UnExecute();
    }
}