    using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int max = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber>max)
            {
                max = inputNumber;
            }
        }
        Console.WriteLine(max);

    }
}
