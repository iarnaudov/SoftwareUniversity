using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] arr = Console.ReadLine()
   .Split(' ').Select(int.Parse).ToArray();
        int k = arr.Length / 4;
        int[] row1left = arr.Take(k).Reverse().ToArray();
        int[] row1right = arr.Reverse().Take(k).ToArray();
        int[] row1 = row1left.Concat(row1right).ToArray();
        int[] row2 = arr.Skip(k).Take(2 * k).ToArray();
        //var sumArr = row1.Select((x, index) => x + row2[index]);
        int[] sumArr = new int[row1.Length];
        for (int i = 0; i < row1.Length; i++)
        {
             sumArr[i] = row1[i] + row2[i];
        }
        Console.WriteLine(string.Join(" ", sumArr));







    }
}

