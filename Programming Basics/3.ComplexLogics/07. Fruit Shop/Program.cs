using System;

class Program
{
    static void Main()
    {
        string product = Console.ReadLine();
        string DayOfWeek = Console.ReadLine().ToLower();
        double num = double.Parse(Console.ReadLine());

        if (num >= 0)
        {


            if (DayOfWeek == "monday" || DayOfWeek == "tuesday" || DayOfWeek == "wednesday" || DayOfWeek == "thursday" || DayOfWeek == "friday")
            {
                switch (product)
                {
                    case "banana": Console.WriteLine(num * 2.50); break;
                    case "apple": Console.WriteLine(num * 1.20); break;
                    case "orange": Console.WriteLine(num * 0.85); break;
                    case "grapefruit": Console.WriteLine(num * 1.45); break;
                    case "kiwi": Console.WriteLine(num * 2.70); break;
                    case "pineapple": Console.WriteLine(num * 5.50); break;
                    case "grapes": Console.WriteLine(num * 3.85); break;
                    default: Console.WriteLine("error"); break;
                }
            }
            else if (DayOfWeek == "saturday" || DayOfWeek == "sunday")
            {
                switch (product)
                {
                    case "banana": Console.WriteLine(num * 2.70); break;
                    case "apple": Console.WriteLine(num * 1.25); break;
                    case "orange": Console.WriteLine(num * 0.90); break;
                    case "grapefruit": Console.WriteLine(num * 1.60); break;
                    case "kiwi": Console.WriteLine(num * 3.00); break;
                    case "pineapple": Console.WriteLine(num * 5.60); break;
                    case "grapes": Console.WriteLine(num * 4.20); break;
                    default: Console.WriteLine("error"); break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else
        {
            Console.WriteLine("error");
        }


    }
}