using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger numberInt = BigInteger.Parse(Console.ReadLine());
        BigInteger result = numberInt;

        for (int i = 1; i < numberInt; i++)
        {
            result = result * i;
        }
        Console.WriteLine(result);



    }
}

