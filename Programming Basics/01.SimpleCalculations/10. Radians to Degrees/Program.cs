using System;

class Program
{
    static void Main()
    {
        double rad = double.Parse(Console.ReadLine());
        double degrees = Math.Round((rad * 180 / Math.PI), 0);
        Console.WriteLine(degrees);
    }
}
