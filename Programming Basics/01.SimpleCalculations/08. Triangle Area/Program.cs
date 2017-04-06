using System;

class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double Square = Math.Round(a * h / 2, 2);
        Console.WriteLine("Triangle area = {0}", Square);
    }
}
