using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;


class Program
{
    static void Main()
    {
        List<string> text1 = File.ReadAllLines("input.txt").ToList();
        List<string> text2 = File.ReadAllLines("input_2.txt").ToList();

        List<string> lines = text1.Concat(text2).ToList();
        var result = lines.OrderBy(a => a);
        File.WriteAllLines("output.txt", result);





    }
}

