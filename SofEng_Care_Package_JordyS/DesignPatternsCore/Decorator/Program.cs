using System;

namespace Decorator
{
    /// <summary>
    /// Attach additional responsibilities to an object dynamically.
    /// Decorators provide a flexible alternative to subclassing for extending functionality.
    /// </summary>
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Create book
            Book book = new Book("Worley", "Inside ASP.NET", 10);
            book.Display();
 
            // Create video
            Video video = new Video("Spielberg", "Jaws", 23, 92);
            video.Display();
 
            // Make video borrowable, then borrow and display
            Console.WriteLine("\nMaking video borrowable:");
 
            Borrowable borrowvideo = new Borrowable(video);
            borrowvideo.BorrowItem("Customer #1");
            borrowvideo.BorrowItem("Customer #2");
            borrowvideo.ReturnItem("Customer #1");
 
            borrowvideo.Display();

            Console.ReadKey();
        }
//        // Strucutral code
//        static void Main()
//        {
//            // Create ConcreteComponent and two Decorators
//
//            ConcreteComponent c = new ConcreteComponent();
//            ConcreteDecoratorA d1 = new ConcreteDecoratorA();
//            ConcreteDecoratorB d2 = new ConcreteDecoratorB();
// 
//            // Link decorators
//
//            d1.SetComponent(c);
//            d2.SetComponent(d1);
// 
//            d2.Operation();
// 
//            // Wait for user
//
//            Console.ReadKey();
//        }
//    }
// 
//    /// <summary>
//    /// The 'Component' abstract class
//    /// </summary>
//
//    abstract class Component
//
//    {
//        public abstract void Operation();
//    }
// 
//    /// <summary>
//    /// The 'ConcreteComponent' class
//    /// </summary>
//
//    class ConcreteComponent : Component
//
//    {
//        public override void Operation()
//        {
//            Console.WriteLine("ConcreteComponent.Operation()");
//        }
//    }
// 
//    /// <summary>
//    /// The 'Decorator' abstract class
//    /// </summary>
//
//    abstract class Decorator : Component
//
//    {
//        protected Component component;
// 
//        public void SetComponent(Component component)
//        {
//            this.component = component;
//        }
// 
//        public override void Operation()
//        {
//            if (component != null)
//            {
//                component.Operation();
//            }
//        }
//    }
// 
//    /// <summary>
//    /// The 'ConcreteDecoratorA' class
//    /// </summary>
//
//    class ConcreteDecoratorA : Decorator
//
//    {
//        public override void Operation()
//        {
//            base.Operation();
//            Console.WriteLine("ConcreteDecoratorA.Operation()");
//        }
//    }
// 
//    /// <summary>
//    /// The 'ConcreteDecoratorB' class
//    /// </summary>
//
//    class ConcreteDecoratorB : Decorator
//
//    {
//        public override void Operation()
//        {
//            base.Operation();
//            AddedBehavior();
//            Console.WriteLine("ConcreteDecoratorB.Operation()");
//        }
// 
//        void AddedBehavior()
//        {
//        }
//    }
//}
    }
}