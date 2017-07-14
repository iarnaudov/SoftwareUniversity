using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int currentNum = 0;
        int minNum = int.MaxValue;
        int maxNum = int.MinValue;
        int sum = 0;

        for (int i = 0; i < arr1.Length; i++)
        {
            currentNum = arr1[i];
            if (currentNum<minNum)
            {
                minNum = currentNum;
            }
            if (currentNum>maxNum)
            {
                maxNum = currentNum;
            }
            sum += arr1[i];
        }
        Console.WriteLine($"Min = {minNum}");
        Console.WriteLine($"Max = {maxNum}");
        Console.WriteLine($"Sum = {sum}");
        Console.WriteLine("Average = {0}",(double)sum/arr1.Length);




    }
}

