using System;
namespace DecoratorPatternDemo
{
    public abstract class ShapeDecorator : Shape
    {

        protected Shape decoratedShape;

        public ShapeDecorator(Shape decoratedShape)
        {
            this.decoratedShape = decoratedShape;
        }

        public virtual void Draw()
        {
            decoratedShape.Draw();
        }
    }
}
