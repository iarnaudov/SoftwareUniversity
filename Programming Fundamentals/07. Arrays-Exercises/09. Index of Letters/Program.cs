using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {

        string input = Console.ReadLine().ToLower();
        char[] array = new char[input.Length];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = input[i];
            int charnum = ((int)array[i]) - 97;
            Console.WriteLine($"{array[i]} -> {charnum}");
        }
    }
}

