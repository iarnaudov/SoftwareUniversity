using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int evenSum = 0;
        int OddSum = 0;

        for (int i = 0; i < n; i++)
        {
            if (i%2==0)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                evenSum += inputNumber;
            }
            else
            {
                int inputNumber = int.Parse(Console.ReadLine());
                OddSum += inputNumber;
            }
        }

        if (evenSum == OddSum)
        {
            Console.WriteLine("Yes, sum = {0}", evenSum);
        }
        else
        {
            Console.WriteLine("No, diff = {0}", Math.Abs(evenSum - OddSum));
        }
    }
}
