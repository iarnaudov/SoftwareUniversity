using System;

class Program
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        int guests = int.Parse(Console.ReadLine());
        double priceBananas = double.Parse(Console.ReadLine());
        double priceEggs = double.Parse(Console.ReadLine());
        double priceBerries = double.Parse(Console.ReadLine());


        double portions = Math.Ceiling(guests / 6.0);
        double PricePerPortion = (2 * priceBananas) + (4 * priceEggs) + (0.2 * priceBerries);
        double TotalPrice = portions * PricePerPortion;

        if (budget >= TotalPrice)
        {
            Console.WriteLine($"Ivancho has enough money - it would cost {TotalPrice:F2}lv.");
        }
        else
        {
            Console.WriteLine("Ivancho will have to withdraw money - he will need {0:F2}lv more.", TotalPrice - budget);
        }

    }
}

