using System;

class Program
{
    static void Main()
    {

        double budjet = double.Parse(Console.ReadLine());
        string season = Console.ReadLine().ToLower();


        if (budjet<=100)
        {
            Console.WriteLine("Economy class");
            if (season== "summer") Console.WriteLine("Cabrio - {0:f2}", budjet*0.35);
            else if (season == "winter") Console.WriteLine("Jeep - {0:f2}", budjet*0.65);
        }

        else if (budjet > 100 && budjet<=500)
        {
            Console.WriteLine("Compact class");
            if (season == "summer") Console.WriteLine("Cabrio - {0:f2}", budjet * 0.45);
            else if (season == "winter") Console.WriteLine("Jeep - {0:f2}", budjet * 0.80);
        }
        else if (budjet > 500)
        {
            Console.WriteLine("Luxury class");
            Console.WriteLine("Jeep - {0:f2}", budjet * 0.90);
        }












    }
}
