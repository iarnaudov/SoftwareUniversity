using System;

class Program
{
    static void Main()
    {
        double celsius = double.Parse(Console.ReadLine());
        double farenheith = Math.Round(celsius * 1.8 + 32, 2);
        Console.WriteLine(farenheith);
        
    }
}
