using System;

class Program
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double Area = Math.PI * r * r;
        double Perimeter = 2 * Math.PI * r;
        Console.WriteLine("Area = {0}", Area);
        Console.WriteLine("Perimeter = {0}", Perimeter);

    }
}
