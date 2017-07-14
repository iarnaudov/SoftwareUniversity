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
        var input = Console.ReadLine();
        var didimon = @"[^a-zA-Z-]+";
        var bojomon = @"[a-zA-Z]+-[a-zA-Z]+";
        var newString = new StringBuilder(input);


        for (int i = 0;; i++)
        {
            if (i%2==0)
            {
                var didiMatch = Regex.Match(input, didimon);

                if (didiMatch.Success)
                {
                    Console.WriteLine(didiMatch);
                    //int firstIndex = didiMatch.Value.LastIndexOf(didiMatch.ToString());
                    int firstIndex = input.IndexOf(didiMatch.Value);
                    if (firstIndex==0)
                    {
                        input = newString.Remove(firstIndex, didiMatch.Length).ToString();
                    }
                    else
                    {
                        input = newString.Remove(0, didiMatch.Length+firstIndex).ToString();
                    }
                  
                }
                else
                {
                    return;
                }
            }
            else
            {
                var bojoMatch = Regex.Match(input, bojomon);
                if (bojoMatch.Success)
                {
                    Console.WriteLine(bojoMatch);
                    int firstIndex = input.IndexOf(bojoMatch.Value);
                    if (firstIndex == 0)
                    {
                        input = newString.Remove(firstIndex, bojoMatch.Length).ToString();
                    }
                    else
                    {
                        input = newString.Remove(0, bojoMatch.Length+firstIndex).ToString();
                    }
                }
                else
                {
                    return;
                }
            }
        }
          

        

    }
}

