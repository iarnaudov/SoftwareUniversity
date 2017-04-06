using System;

class Program
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        if (num1 < 1 || num1 > 50)
        {
            Console.WriteLine("Wrong time");
        }
        int num2 = int.Parse(Console.ReadLine());
        if (num2 < 1 || num2 > 50)
        {
            Console.WriteLine("Wrong time");
        }
        int num3 = int.Parse(Console.ReadLine());
        if (num3 < 1 || num3 > 50)
        {
            Console.WriteLine("Wrong time");
        }
        int sum = num1 + num2 + num3;
        int minutes = sum / 60;
        int seconds = sum % 60;

        if (seconds < 10)
        {
            Console.WriteLine("{0}:0{1}", minutes, seconds);
        }
        else
        {
            Console.WriteLine("{0}:{1}", minutes, seconds);
        }

    }
}
