using System;
namespace DecoratorPatternDemo
{
    public class RedShapeDecorator: ShapeDecorator
    {
        public RedShapeDecorator(Shape decoratedShape): base(decoratedShape)
        {
            
        }

        public override void Draw()
        {
            decoratedShape.Draw();
            setRedBorder(decoratedShape);
        }

        private void setRedBorder(Shape decoratedShape)
        {
            Console.WriteLine("Border Color: Red");
        }
    }
}
