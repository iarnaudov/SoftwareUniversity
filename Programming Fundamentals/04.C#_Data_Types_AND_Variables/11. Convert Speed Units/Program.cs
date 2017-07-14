using System;

class Program
{
    static void Main()
    {
        double distance = double.Parse(Console.ReadLine());
       double hours = double.Parse(Console.ReadLine());
        double minutes = double.Parse(Console.ReadLine());
        double seconds = double.Parse(Console.ReadLine());

        double totalSecond = (hours * 3600 + minutes * 60 + seconds);
        double metersPerSecond = (float)distance / totalSecond;
        Console.WriteLine((float)metersPerSecond);

        double totalHours = hours + minutes / 60 + seconds / 3600;
        double kmPerHour = (distance / 1000) / totalHours;
        Console.WriteLine((float)kmPerHour);
        decimal miPerHour = ((decimal)distance / 1609) / ((decimal)totalSecond/3600);

        Console.WriteLine(Math.Round(miPerHour, 7, MidpointRounding.AwayFromZero));
    }
}

