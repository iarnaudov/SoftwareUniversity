using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<double> items = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
        items.Sort();

        Console.WriteLine(string.Join(" <= ", items));




    }
}

