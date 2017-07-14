using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<string> nums = Console.ReadLine().Split(' ').ToList();
        
        while (true)
        {
            string[] command = Console.ReadLine().Split(' ').ToArray();
            if (command[0]=="Delete")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (command[1]==nums[i])
                    {
                        nums.Remove(nums[i]);
                    }
                }
            }
            else if (command[0] == "Insert")
            {
                nums.Insert(int.Parse(command[2]), command[1]);
            }
           else if (command[0] == "Odd")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (int.Parse(nums[i]) % 2 == 0)
                    {
                        nums.Remove(nums[i]);
                        i--;
                    }
                }
                Console.WriteLine(string.Join(" ", nums));
                return;
            }
           else  if (command[0] == "Even")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (int.Parse(nums[i]) % 2 != 0)
                    {
                        nums.Remove(nums[i]);
                        i--;
                    }
                }
                Console.WriteLine(string.Join(" ", nums));
                return;
            }





        }
    }
}

