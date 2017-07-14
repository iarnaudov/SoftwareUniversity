using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        char[] separators = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' '};
        string[] words = Console.ReadLine().ToLower().Split(separators);

      
            var result = words.Where(x => x != "")
                         .Where(x => x.Length < 5)
                         .OrderBy(x => x)
                         .Distinct();
        Console.WriteLine(string.Join(", ", result));
      


    }
}

