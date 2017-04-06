using System;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        bool range = (num >= 100 && num <= 200) || num==0;
        if (!range)
        {
            Console.WriteLine("invalid");
        }
    }
}
