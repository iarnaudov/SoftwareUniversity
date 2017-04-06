using System;

class Program
{
    static void Main()
    {
        Console.Write("Input a: ");
        var a = decimal.Parse(Console.ReadLine());
        Console.Write("Input b: ");
        var b = decimal.Parse(Console.ReadLine());
        var sum = a * b;
        Console.WriteLine("The Square of the Rectangle is: {0}", sum);

    }
}
