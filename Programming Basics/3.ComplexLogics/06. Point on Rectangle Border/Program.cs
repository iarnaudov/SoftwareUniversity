using System;

class Program
{
    static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        bool isOnLeftSide = x == x1 && (y1 <= y && y <= y2);
        bool isOnRightSide = x == x2 && (y1 <= y && y <= y2);
        bool isOnUpSide = y == y1 && (x1 <= x && x <= x2);
        bool isOnDownSide = y == y2 && (x1 <= x && x <= x2);

        if ( isOnLeftSide || isOnRightSide || isOnUpSide || isOnDownSide)
        {
            Console.WriteLine("Border");
        }
        else
        {
            Console.WriteLine("Inside / Outside");
        }
    }
}
