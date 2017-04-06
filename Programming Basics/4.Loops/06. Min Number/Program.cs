using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber < min)
            {
                min = inputNumber;
            }
        }
        Console.WriteLine(min);

    }
}
