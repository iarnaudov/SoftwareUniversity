using System;

class Program
{
    static void Main()
    {
        string figure = Console.ReadLine();
        Console.WriteLine("{0:f2}",PrintFigureArea(figure));
    }

    private static double PrintFigureArea(string figure)
    {
        double result=0;
        switch (figure)
        {
            case "triangle":
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                result = (side * height) / 2; break;
            case "square":
                double squareSide = double.Parse(Console.ReadLine());
                result = squareSide * squareSide; break;
            case "rectangle":
                double width = double.Parse(Console.ReadLine());
                double rectangleHeight = double.Parse(Console.ReadLine());
                result = width * rectangleHeight; break;

            case "circle":
                double radius = double.Parse(Console.ReadLine());
                result = Math.PI * (Math.Pow(radius, 2)); break;

            default:
                break;
        }
        return result;
    }
}

