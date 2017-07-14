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
        var text = File.ReadAllText("sample_text.txt").Where(a => a == '.' || a==',' || a=='!' || a == '?' || a == ':');
        Console.WriteLine(string.Join(", ", text)); 




    }
}

