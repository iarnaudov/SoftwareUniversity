using System;

class Program
{
    static void Main()
    {
        string type = Console.ReadLine().ToLower();
       double r = double.Parse(Console.ReadLine());
       double c = double.Parse(Console.ReadLine());
       double num = r * c;

        switch (type)
        {
            case "premiere": Console.WriteLine("{0:f2}", 12.00* num); break;
            case "normal": Console.WriteLine("{0:f2}", 7.50 * num); break;
            case "discount": Console.WriteLine("{0:f2}", 5.00 * num); break;
            default:
                break;
        }
        
    }
}
