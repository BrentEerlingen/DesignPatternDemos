using System;

namespace Factory_Method
{
    /// <summary>
    /// Factory Method
    /// Define an interface for creating an object, but let subclasses decide which class to instantiate.
    /// Factory Method lets a class defer instantiation to subclasses.
    /// </summary>
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Note: constructors call Factory Method

            Document[] documents = new Document[2];

            documents[0] = new Resume();
            documents[1] = new Report();

            // Display document pages

            foreach (Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }

            Console.ReadKey();
        }
//        // Strucural Code
//        static void Main()
//            {
//                // An array of creators
//
//                Creator[] creators = new Creator[2];
// 
//                creators[0] = new ConcreteCreatorA();
//                creators[1] = new ConcreteCreatorB();
// 
//                // Iterate over creators and create products
//
//                foreach (Creator creator in creators)
//                {
//                    Product product = creator.FactoryMethod();
//                    Console.WriteLine("Created {0}",
//                        product.GetType().Name);
//                }
// 
//                // Wait for user
//
//                Console.ReadKey();
//            }
//        }
// 
//        /// <summary>
//        /// The 'Product' abstract class
//        /// </summary>
//        abstract class Product
//
//        {
//        }
// 
//        /// <summary>
//        /// A 'ConcreteProduct' class
//        /// </summary>
//        class ConcreteProductA : Product
//
//        {
//        }
// 
//        /// <summary>
//        /// A 'ConcreteProduct' class
//        /// </summary>
//        class ConcreteProductB : Product
//
//        {
//        }
// 
//        /// <summary>
//        /// The 'Creator' abstract class
//        /// </summary>
//        abstract class Creator
//
//        {
//            public abstract Product FactoryMethod();
//        }
// 
//        /// <summary>
//        /// A 'ConcreteCreator' class
//        /// </summary>
//        class ConcreteCreatorA : Creator
//
//        {
//            public override Product FactoryMethod()
//            {
//                return new ConcreteProductA();
//            }
//        }
// 
//        /// <summary>
//        /// A 'ConcreteCreator' class
//        /// </summary>
//        class ConcreteCreatorB : Creator
//
//        {
//            public override Product FactoryMethod()
//            {
//                return new ConcreteProductB();
//            }
//        }
//    }
    }
}