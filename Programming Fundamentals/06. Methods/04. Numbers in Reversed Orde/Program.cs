using System;

class Program
{
    static void Main()
    {
        var num = decimal.Parse(Console.ReadLine());
        var reversedNum = ReverseNumDigits(num);
        Console.WriteLine(reversedNum);
    }

    private static decimal ReverseNumDigits(decimal num)
    {
        var numToString = num.ToString();
        var result = string.Empty;
        for (int i = numToString.Length - 1; i >= 0; i--)
        {
            result += numToString[i];
        }
        return decimal.Parse(result);
    }
}

