using System;

class Program
{
    static void Main()
    {
        double USD = double.Parse(Console.ReadLine());
        double BGN = Math.Round(USD * 1.79549, 2);
        Console.WriteLine("{0} BGN", BGN);
    }
}
