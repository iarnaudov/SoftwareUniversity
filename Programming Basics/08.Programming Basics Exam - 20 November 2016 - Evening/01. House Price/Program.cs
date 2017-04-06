using System;

class Program
{
    static void Main()
    {
        double smallestRoom = double.Parse(Console.ReadLine()); 
        double Kitchen = double.Parse(Console.ReadLine());
        double PriceSqM =  double.Parse(Console.ReadLine());

        double Secondroom = smallestRoom * 1.1;
        double Thirdroom = Secondroom * 1.1;
        double Bathroom = smallestRoom / 2;

        double Total = (smallestRoom + Secondroom + Thirdroom + Bathroom+Kitchen) * 1.05;
        double TotalPrice = Total * PriceSqM;
        Console.WriteLine("{0:f2}",TotalPrice);
    }
}
