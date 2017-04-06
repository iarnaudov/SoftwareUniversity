using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int max = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            sum += inputNumber;

            if (inputNumber > max)
            {
                max = inputNumber;
            }
        }
            if (sum==2*max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", max);
            }
            else
            {
                int diff = Math.Abs(2*max - sum);
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", diff);
            }
        for (int i = 0; i < 5; i++)
        {

        }
       
    }
}
