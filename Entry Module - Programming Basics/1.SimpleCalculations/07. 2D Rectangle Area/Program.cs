using System;

class Program
{
    static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double a = Math.Abs(x1 - x2);
        double b = Math.Abs(y1 - y2);
        double Square = a * b;
        double Perimeter = 2 * (a + b);
        Console.WriteLine(Square);
        Console.WriteLine(Perimeter);
    }
}
