using System;

class Program
{
    static void Main()
    {
        string trade = Console.ReadLine();
        double num = double.Parse(Console.ReadLine());
            switch (trade)
            {
                case "Athlete": Console.WriteLine("The {1} has to pay {0:f2}.", num * 0.70, trade); break;
                case "Businessman": Console.WriteLine("The {1} has to pay {0:f2}.", num * 1, trade); break;
                case "Businesswoman": Console.WriteLine("The {1} has to pay {0:f2}.", num * 1, trade); break;
                case "SoftUni Student": Console.WriteLine("The {1} has to pay {0:f2}.", num * 1.70, trade); break;
                default: Console.WriteLine("The {1} has to pay {0:f2}.", num * 1.20, trade); break;
            }


     

    }
}

