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

        string[] lines = File.ReadAllLines("nnn.txt");

        var numberedLines = lines.Select((line, index) => $"{index + 1}. {line}");
        File.WriteAllLines("zzz.txt", numberedLines);
      


    }
}

