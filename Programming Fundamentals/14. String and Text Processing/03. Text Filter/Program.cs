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
        string[] banWords = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries); // TODO: add separators
        string text = Console.ReadLine();
        foreach (var banWord in banWords)
        {
            if (text.Contains(banWord))
            {
                text = text.Replace(banWord,new string('*', banWord.Length));
            }
        }
        Console.WriteLine(text);





    }
}

