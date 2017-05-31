using System;

class Program
{
    static void Main()
    {
        string trade = Console.ReadLine().ToLower();
        switch (trade)
        {
            case "athlete": Console.WriteLine("Water"); break;
            case "businessman":
            case "businesswoman": Console.WriteLine("Coffee"); break;
            case "softuni student": Console.WriteLine("Beer"); break;
            default: Console.WriteLine("Tea"); break;
        }



    }
}

