using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger result = Factorial(n);
        Console.WriteLine(TrailingZero(result));
    }

    private static int TrailingZero(BigInteger result)
    {
        int zeroCounter = 0;
        while (result % 10 == 0)
        {
            result = result / 10;
            zeroCounter++;
        }
        return zeroCounter;
    }

    private static BigInteger Factorial(BigInteger n)
    {
        BigInteger result = n;
        for (BigInteger i = n-1; i > 0; i--)
        {
            result = result * i;
        }
        return result;
    }
}

