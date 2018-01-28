using System;

namespace Command
{
    /// <summary>
    /// Encapsulate a request as an object, thereby letting you parameterize clients with different requests, 
    /// queue or log requests, and support undoable operations.
    /// The 'Client' class
    /// creates a ConcreteCommand (CalculatorCommand) object and sets its receiver
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Create user and let her compute

            User user = new User();
 
            // User presses calculator buttons

            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);
 
            // Undo 4 commands

            user.Undo(4);
 
            // Redo 3 commands

            user.Redo(3);
 
            // Wait for user

            Console.ReadKey();
        }
//        // Structural code
//        static void Main()
//        {
//            // Create receiver, command, and invoker
//
//            Receiver receiver = new Receiver();
//            Command command = new ConcreteCommand(receiver);
//            Invoker invoker = new Invoker();
// 
//            // Set and execute command
//
//            invoker.SetCommand(command);
//            invoker.ExecuteCommand();
// 
//            // Wait for user
//
//            Console.ReadKey();
//        }
//    }
// 
//    /// <summary>
//
//    /// The 'Command' abstract class
//
//    /// </summary>
//
//    abstract class Command
//
//    {
//        protected Receiver receiver;
// 
//        // Constructor
//
//        public Command(Receiver receiver)
//        {
//            this.receiver = receiver;
//        }
// 
//        public abstract void Execute();
//    }
// 
//    /// <summary>
//
//    /// The 'ConcreteCommand' class
//
//    /// </summary>
//
//    class ConcreteCommand : Command
//
//    {
//        // Constructor
//
//        public ConcreteCommand(Receiver receiver) :
//            base(receiver)
//        {
//        }
// 
//        public override void Execute()
//        {
//            receiver.Action();
//        }
//    }
// 
//    /// <summary>
//
//    /// The 'Receiver' class
//
//    /// </summary>
//
//    class Receiver
//
//    {
//        public void Action()
//        {
//            Console.WriteLine("Called Receiver.Action()");
//        }
//    }
// 
//    /// <summary>
//
//    /// The 'Invoker' class
//
//    /// </summary>
//
//    class Invoker
//
//    {
//        private Command _command;
// 
//        public void SetCommand(Command command)
//        {
//            this._command = command;
//        }
// 
//        public void ExecuteCommand()
//        {
//            _command.Execute();
//        }
//    }
//}
    }
}