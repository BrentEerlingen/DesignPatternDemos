using System;
namespace DecoratorPatternDemo
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
