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
        var word = Console.ReadLine();
        var sentence = new StringBuilder(Console.ReadLine());
        sentence.Replace(word, new string('*', word.Length));
        Console.WriteLine(sentence);
    }
}

