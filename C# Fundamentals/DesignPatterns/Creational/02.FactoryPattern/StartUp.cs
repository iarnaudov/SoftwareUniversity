using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class StartUp
    {
        /// <summary>
        /// Responsible for creating different types of objects without exposing the complicated creation logic.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            //get an object of Circle and call its draw method.
            Shape shape1 = shapeFactory.GetShape(Shapes.Circle);

            //call draw method of Circle
            shape1.Draw();

            //get an object of Rectangle and call its draw method.
            Shape shape2 = shapeFactory.GetShape(Shapes.Rectangle);

            //call draw method of Rectangle
            shape2.Draw();

            //get an object of Square and call its draw method.
            Shape shape3 = shapeFactory.GetShape(Shapes.Square);

            //call draw method of square
            shape3.Draw();

        }
    }
}
