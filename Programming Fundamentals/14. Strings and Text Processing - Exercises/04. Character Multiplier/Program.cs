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

        var input = Console.ReadLine().Split().ToArray();
        
        Console.WriteLine(CharMultiplier(input[0], input[1]));

    }

    private static int CharMultiplier(string a, string b)
    {
        int result = 0;
        int sum = 0;
        if (a.Length == b.Length)
        {
            for (int i = 0; i < a.Length; i++)
            {
               result = a[i] * b[i];
                sum += result;
            }
        }
        else if (a.Length != b.Length)
        {
            var minLenght = Math.Min(a.Length, b.Length);
            var maxLenght = Math.Max(a.Length, b.Length);
            for (int i = 0; i < minLenght; i++)
            {
                result = a[i] * b[i];
                sum += result;
            }
            if (a.Length>b.Length)
            {
                for (int i = a.Length-1; i >= b.Length; i--)
                {
                    sum += a[i];
                }
            }
            else if (a.Length < b.Length)
            {
                for (int i = b.Length - 1; i >= a.Length; i--)
                {
                    sum += b[i];
                }
            }
        }
        return sum;
    }
}

