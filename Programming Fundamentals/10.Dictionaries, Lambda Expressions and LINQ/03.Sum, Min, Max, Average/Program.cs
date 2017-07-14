using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {

        var n = int.Parse(Console.ReadLine());
        List<int> nums = new List<int>();
        for (int i = 0; i < n; i++)
        {
            int variable = int.Parse(Console.ReadLine());
            nums.Add(variable);
        }
        Console.WriteLine("Sum = {0}", nums.Sum());
        Console.WriteLine("Sum = {0}", nums.Min());
        Console.WriteLine("Sum = {0}", nums.Max());
        Console.WriteLine("Sum = {0}", nums.Average());


    }
}

