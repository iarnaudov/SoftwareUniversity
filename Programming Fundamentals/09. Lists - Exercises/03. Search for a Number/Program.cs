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
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        List<int> newNums = new List<int>();

        for (int i = 0; i < arr[0]; i++)
        {
            newNums.Add(nums[i]);
        }
        for (int i = 0; i < arr[1]; i++)
        {
            newNums.RemoveAt(0);
        }
        for (int i = 0; i < newNums.Count; i++)
        {
            if (newNums[i] == arr[2])
            {
                Console.WriteLine("YES!");
                return;
            }
        }
        Console.WriteLine("NO!");


    }
}

