using System;

class Program
{
    static void Main()
    {
        decimal days = decimal.Parse(Console.ReadLine());
        decimal runners = decimal.Parse(Console.ReadLine());
        decimal laps = decimal.Parse(Console.ReadLine());
        decimal trackLenght = decimal.Parse(Console.ReadLine()); //in meters
        decimal trackRunnersCapacity = decimal.Parse(Console.ReadLine());
        decimal moneyPerKm = decimal.Parse(Console.ReadLine());
        decimal realRunners = 0;
        //-------------------------------------------------------------------//
        decimal maxRunners = trackRunnersCapacity * days;
        if (runners<=maxRunners)
        {
             realRunners = runners;
        }
        else
        {
             realRunners = maxRunners;
        }
        decimal totalKm = (realRunners * laps * trackLenght)/1000;
        decimal moneyRaised = totalKm * moneyPerKm;
        Console.WriteLine($"Money raised: {moneyRaised:f2}");
   }
}

