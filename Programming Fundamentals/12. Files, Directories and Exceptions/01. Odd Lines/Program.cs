using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("input.txt");

        var oddLines = lines.Where((line, index) => index % 2 == 1);
        File.WriteAllLines("odd-lines.txt", oddLines);



    }
}

