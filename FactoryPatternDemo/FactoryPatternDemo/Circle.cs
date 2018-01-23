using System;
namespace FactoryPatternDemo
{
    public class Circle: Shape
    {
        public Circle()
        {
        }

        public void Draw()
        {
            Console.WriteLine("Shape: Circle");
        }
    }
}
