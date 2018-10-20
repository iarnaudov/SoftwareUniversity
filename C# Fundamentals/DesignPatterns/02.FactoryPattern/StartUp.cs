﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            //get an object of Circle and call its draw method.
            Shape shape1 = shapeFactory.GetShape("CIRCLE");

            //call draw method of Circle
            shape1.Draw();

            //get an object of Rectangle and call its draw method.
            Shape shape2 = shapeFactory.GetShape("RECTANGLE");

            //call draw method of Rectangle
            shape2.Draw();

            //get an object of Square and call its draw method.
            Shape shape3 = shapeFactory.GetShape("SQUARE");

            //call draw method of square
            shape3.Draw();

        }
    }
}
