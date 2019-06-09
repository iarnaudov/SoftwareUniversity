using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class ShapeFactory
    {
        //use GetShape method to get object of type shape 
        public Shape GetShape(Shapes shapeType)
        {
            if (shapeType.Equals(Shapes.Circle))
            {
                return new Circle();

            }
            else if (shapeType.Equals(Shapes.Rectangle))
            {
                return new Rectangle();

            }
            else if (shapeType.Equals(Shapes.Square))
            {
                return new Square();
            } else
            {
                return null;
            }
        }
    }
}
