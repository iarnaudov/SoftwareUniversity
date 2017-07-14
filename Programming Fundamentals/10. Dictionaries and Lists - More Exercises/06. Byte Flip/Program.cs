using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<string> randomString = Console.ReadLine().Split(' ').ToList();
        randomString.RemoveAll(x => x.Length != 2);

        for (int i = randomString.Count - 1; i >= 0; i--)
        {
            var currentReversedText = string.Concat(randomString[i].Reverse());
            randomString[i] = currentReversedText;
        }
        randomString.Reverse();
        foreach (var item in randomString)
        {
            Console.Write(ConvertFromHexadecimalToChars(item));

        }
        Console.WriteLine();
    }
    public static char ConvertFromHexadecimalToChars(string input)
    {
        return (char)Convert.ToInt32(input, 16);
    }
}


