using System;

class Program
{
    static void Main()
    {
        decimal n = decimal.Parse(Console.ReadLine());
        decimal m = decimal.Parse(Console.ReadLine());
        decimal result = (n * m) / 1000000;
        Console.WriteLine("{0}x{1} => {2}MP", n,m,Math.Round(result,1));
    }
}

