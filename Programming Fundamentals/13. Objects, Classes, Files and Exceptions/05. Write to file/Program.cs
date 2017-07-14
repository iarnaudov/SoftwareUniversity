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
        string[] text = File.ReadAllText("sample_text.txt").Split(new char[] {' ', '.', ',', '!', '?', ':'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
        Console.WriteLine(string.Join(" ", text));




    }
}

