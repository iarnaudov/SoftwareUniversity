using System;

class Program
{
    static void Main()
    {
        int hour = int.Parse(Console.ReadLine());
        if (hour < 0 || hour > 23)
        {
            Console.WriteLine("invalid hour");
        }
        int min = int.Parse(Console.ReadLine());
        if (min < 0 || min > 59)
        {
            Console.WriteLine("invalid minutes");

        }


        int addMin = min + 15;
        if (addMin > 59)
        {
            addMin = addMin % 60;
            hour = hour + 1;
            if (hour == 24)
            {
                hour = 0;
            }
            Console.WriteLine("{0}:{1:00}", hour, addMin);
        }
        else if (hour > 23)
        {
            hour = 0;
            Console.WriteLine("{0}:{1:00}", hour, addMin);
        }
        else
        {
            Console.WriteLine("{0}:{1:00}", hour, addMin);
        }

    }
}
