using System;

class Program
{
    static void Main()
    {

        string product = Console.ReadLine();
        double volume = double.Parse(Console.ReadLine());
        double kcal =   double.Parse(Console.ReadLine());
        double sugar =  double.Parse(Console.ReadLine());
        double Totalkcal = kcal * (volume / 100);
        double Totalsugar = sugar * (volume / 100);
        Console.WriteLine("{0}ml {1}:", volume,product);
        Console.WriteLine("{0}kcal, {1}g sugars", Totalkcal, Totalsugar);


    }
}

