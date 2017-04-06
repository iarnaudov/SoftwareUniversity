using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;

        while (n > 0)
        {
            int rem = n % 10;
            sum += rem;
            n = n / 10;

        }
        Console.WriteLine(sum);
    }
}
