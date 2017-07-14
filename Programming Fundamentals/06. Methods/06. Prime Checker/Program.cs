using System;

class Program
{
    static void Main()
    {

        var num = long.Parse(Console.ReadLine());

        var isPrime = IsPrime(num);
        Console.WriteLine(isPrime);

    }

    private static bool IsPrime(long num)
    {
        var numSqrt = Math.Sqrt(num);
        if (num==0 || num == 1)
        {
            return false;
        }
        if (num==2)
        {
            return true;
        }
        for (int i = 2; i <= numSqrt; i++)
        {
            if (num%i==0)
            {
                return false;
            }
        }
        return true;
    }
}

