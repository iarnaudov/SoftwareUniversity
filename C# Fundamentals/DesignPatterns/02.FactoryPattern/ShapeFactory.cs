using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class ShapeFactory
    {
        //use GetShape method to get object of type shape 
        public Shape GetShape(string shapeType)
        {
            if (shapeType.Equals("CIRCLE"))
            {
                return new Circle();

            }
            else if (shapeType.Equals("RECTANGLE"))
            {
                return new Rectangle();

            }
            else if (shapeType.Equals("SQUARE"))
            {
                return new Square();
            } else
            {
                return null;
            }
        }
    }
}
