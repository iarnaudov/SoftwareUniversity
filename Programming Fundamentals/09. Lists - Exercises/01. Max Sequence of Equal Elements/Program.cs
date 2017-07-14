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
        List<int> resultList = new List<int>();
        List<int> finalList = new List<int>();
        int counter = 1;
        int maxCounter = 1;
        resultList.Add(nums[0]);

        for (int i = 0; i < nums.Count-1; i++)
        {
            if (nums[i] == nums[i+1])
            {
                counter++;
                resultList.Add(nums[i+1]);
            }
            else
            {
                counter = 1;
                resultList.Clear();
                resultList.Add(nums[i+1]);
            }
            if (counter > maxCounter)
            {
                finalList.Clear();
                maxCounter = counter;
                finalList.AddRange(resultList);
            }

        }
        if (maxCounter == 1)
        {
            Console.WriteLine(nums[0]);
            return;
        }
        Console.WriteLine(string.Join(" ", finalList));



    }
}

