using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<int> nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
        
        List<int> positiveNums = new List<int>();

        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] >= 0)
            {
                positiveNums.Add(nums[i]);
            }
        }
        if (positiveNums.Count==0)
        {
            Console.WriteLine("empty");
        }
        else
        {
            positiveNums.Reverse();
            Console.WriteLine(string.Join(" ", positiveNums));
        }
      



    }
}

