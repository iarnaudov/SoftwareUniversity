using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split('>').ToList();
        var regex = new Regex(@"\d+");
        var naum = 0;

        for (int i = 1; i < input.Count; i++)
        {
            var strenght = int.Parse(regex.Match(input[i]).Value)+naum;
            try
            {
                input[i] = input[i].Remove(0, strenght);
                naum = 0;
            }
            catch (Exception)
            {
                naum = strenght - input[i].Length;
                input[i] = input[i].Remove(0);     
            } 
            
        }
       Console.WriteLine(string.Join(">",input));


    }
}

