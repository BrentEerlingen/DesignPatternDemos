using System;

namespace Template_Method
{
    /// <summary>
    /// Define the skeleton of an algorithm in an operation, deferring some steps to subclasses. 
    /// Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            DataExporter exporter = null;

            // Lets export the data to Excel file
            exporter = new ExcelExporter();
            exporter.ExportFormatedData();

            Console.WriteLine();

            // Lets export the data to PDF file
            exporter = new PDFExporter();
            exporter.ExportFormatedData();
        }

//        // Strucural code
//        static void Main()
//        {
//            AbstractClass aA = new ConcreteClassA();
//            aA.TemplateMethod();
// 
//            AbstractClass aB = new ConcreteClassB();
//            aB.TemplateMethod();
// 
//            // Wait for user
//
//            Console.ReadKey();
//        }
//    }
// 
//    /// <summary>
//
//    /// The 'AbstractClass' abstract class
//
//    /// </summary>
//
//    abstract class AbstractClass
//
//    {
//        public abstract void PrimitiveOperation1();
//        public abstract void PrimitiveOperation2();
// 
//        // The "Template method"
//
//        public void TemplateMethod()
//        {
//            PrimitiveOperation1();
//            PrimitiveOperation2();
//            Console.WriteLine("");
//        }
//    }
// 
//    /// <summary>
//
//    /// A 'ConcreteClass' class
//
//    /// </summary>
//
//    class ConcreteClassA : AbstractClass
//
//    {
//        public override void PrimitiveOperation1()
//        {
//            Console.WriteLine("ConcreteClassA.PrimitiveOperation1()");
//        }
//        public override void PrimitiveOperation2()
//        {
//            Console.WriteLine("ConcreteClassA.PrimitiveOperation2()");
//        }
//    }
// 
//    /// <summary>
//
//    /// A 'ConcreteClass' class
//
//    /// </summary>
//
//    class ConcreteClassB : AbstractClass
//
//    {
//        public override void PrimitiveOperation1()
//        {
//            Console.WriteLine("ConcreteClassB.PrimitiveOperation1()");
//        }
//        public override void PrimitiveOperation2()
//        {
//            Console.WriteLine("ConcreteClassB.PrimitiveOperation2()");
//        }
//    }
//}
    }
}