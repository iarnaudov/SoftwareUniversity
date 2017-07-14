using System;

class Program
{
    static void Main()
    {
        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());

        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());

        if (Point1IsCloserToCenter(x1,y1,x2,y2))
        {
            Console.WriteLine($"({x1}, {y1})");
        }
        else
        {
            Console.WriteLine($"({x2}, {y2})");
        }
    }

    private static bool Point1IsCloserToCenter(int x1, int y1, int x2, int y2)
    {
        var distance = CalculateDistanceBetweenPoints(x1, y1, 0, 0);
        var distance2 = CalculateDistanceBetweenPoints(x2, y2, 0, 0);
        if (distance<distance2)
        {
            return true; 
        }
        else
        {
            return false;
        }




    }

    private static double CalculateDistanceBetweenPoints(double x1, double y1, double x2, double y2)
    {
        var distance = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2));
        return distance;
    }
}

