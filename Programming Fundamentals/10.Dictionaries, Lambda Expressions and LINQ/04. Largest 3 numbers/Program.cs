using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {


         List<int> nums = Console.ReadLine().ToLower().Split().Select(int.Parse).ToList();

        var result = nums.OrderByDescending(x => x).Take(3);

          Console.WriteLine(string.Join(" ", result));

    }
}

