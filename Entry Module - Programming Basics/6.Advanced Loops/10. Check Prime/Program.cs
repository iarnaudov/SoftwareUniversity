using System;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int i = 2;

        while (true)
        {
            if (num % i == 0 && i < num)
            {
                Console.WriteLine("Not prime");
                break;
            }
            i++;
        }
    }
}
