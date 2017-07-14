using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var startNum = int.Parse(Console.ReadLine());
        var endNum = int.Parse(Console.ReadLine());

        var primes = FindPrimesInRage(startNum, endNum);

        Console.WriteLine(string.Join(", ", primes));

    }

    private static List<int> FindPrimesInRage(int startNum, int endNum)
    {
        var primes = new List<int>();
        for (int i = startNum; i < endNum; i++)
        {
            if (IsPrime(i))
            {
                primes.Add(i);
            }
        }
        return primes;
    }

    private static bool IsPrime(long num)
    {
        var numSqrt = Math.Sqrt(num);
        if (num == 0 || num == 1)
        {
            return false;
        }
        if (num == 2)
        {
            return true;
        }
        for (int i = 2; i <= numSqrt; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}

