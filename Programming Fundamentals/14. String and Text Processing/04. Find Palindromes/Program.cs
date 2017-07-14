using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        var result = new List<string>();
        foreach (var item in input)
        {
            string first = item.Substring(0, item.Length / 2);
            char[] arr = item.ToCharArray();
            Array.Reverse(arr);
            string temp = new string(arr);

            string second = temp.Substring(0, temp.Length / 2);
            if (first.Equals(second))
            {
                result.Add(item);
            }
        }
        var sorted = result.OrderBy(a => a).ToArray();
        Console.WriteLine(string.Join(", ", sorted));
    }
}