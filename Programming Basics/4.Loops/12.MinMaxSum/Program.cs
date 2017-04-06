using System;

class Program
{
    static void Main()
    {

        double n = double.Parse(Console.ReadLine());
        double max = double.MinValue;
        double min = double.MaxValue;
        double sum = 0;

        for (int i = 0; i < n; i++)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            sum += inputNumber;
            if (inputNumber > max)
            {
                max = inputNumber;
            }
            if (inputNumber < min)
            {
                min = inputNumber;
            }
        }
        Console.WriteLine("Minimum: {0}", min);
        Console.WriteLine("Maximum: {0}", max);
        Console.WriteLine("The sum: {0}", sum);

    }
}
