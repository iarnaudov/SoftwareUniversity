using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {

        List<int> items = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        var result = new List<int>();

        foreach (var item in items)
        {
            if (Math.Sqrt(item) == (int)Math.Sqrt(item))
            {
                result.Add(item);
            }
        }
        result.Sort();
        result.Reverse();
        Console.WriteLine(string.Join(" ", result));

    }
}

