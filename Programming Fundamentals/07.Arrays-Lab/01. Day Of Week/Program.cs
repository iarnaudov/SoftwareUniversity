using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        switch (input)
        {
            case "1": Console.WriteLine(weekDays[0]); break;
            case "2": Console.WriteLine(weekDays[1]); break;
            case "3": Console.WriteLine(weekDays[2]); break;
            case "4": Console.WriteLine(weekDays[3]); break;
            case "5": Console.WriteLine(weekDays[4]); break;
            case "6": Console.WriteLine(weekDays[5]); break;
            case "7": Console.WriteLine(weekDays[6]); break;
            default: Console.WriteLine("Invalid day!"); break;
        }
    }
}

