using System;
namespace FactoryPatternDemo
{
    public class ShapeFactory
    {
        public ShapeFactory()
        {
            
        }

        public Shape GetShape(string shapeType){
            if (shapeType == null)
            {
                return null;
            }
            if (shapeType.Equals("CIRCLE"))
            {
                return new Circle();

            }
            else if (shapeType.Equals("RECTANGLE"))
            {
                return new Rectangle();

            }

            return null;
        }
    }
}
