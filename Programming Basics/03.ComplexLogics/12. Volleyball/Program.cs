using System;

class Program
{
    static void Main()
    {
        string year = Console.ReadLine().ToLower();
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        var SofiaWeek = 48 - h;
        var PlaySofia = (3.0 / 4) * SofiaWeek;
        var PlayHolidays = (2.0 / 3) * p;
        var PlaySum = PlaySofia + PlayHolidays + h;

        if (year=="leap")
        {
            var PlayResult = PlaySum + PlaySum * 0.15;
            Console.WriteLine(Math.Floor(PlayResult));
        }
        else if (year == "normal")
        { 
            Console.WriteLine(Math.Floor(PlaySum));
        }
        else
        {
            Console.WriteLine("error");
        }
       
    }
}
