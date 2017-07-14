using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> temp = new List<int>();
        List<int> reversedNums = new List<int>();
        decimal sum = 0;

        foreach (var num in nums)
        {
           sum += ReverseNumDigits(num);
        }
        Console.WriteLine(sum);


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

