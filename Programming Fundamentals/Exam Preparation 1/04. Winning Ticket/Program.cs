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
        string[] tickets = Regex.Split(Console.ReadLine(), @"\s*,\s*")
            .Select(t => t.Trim())
            .Where(t => t.Length > 0).ToArray();
        foreach (var t in tickets)
        {
            if (t.Length !=20)
            {
                Console.WriteLine("invalid ticket");
            }
            else
            {
                var leftSide = t.Substring(0, 10);
                var rightSide = t.Substring(10);
                var leftLongestSeq = FindMaxEqualSeq(leftSide);
                var rightLongestSeq = FindMaxEqualSeq(rightSide);
                var leftChar = leftLongestSeq[0];
                var rightChar = rightLongestSeq[0];
                if (leftLongestSeq.Length >= 6
                    && leftChar == rightChar
                    && rightLongestSeq.Length
                    >= 6 && leftLongestSeq[0] 
                    == rightLongestSeq[0]
                    && "@#$^".Contains(leftLongestSeq[0]))
                {
                    var count = Math.Min(leftLongestSeq.Length, rightLongestSeq.Length);
                    Console.Write($"ticket \"{t}\" - {count}{leftLongestSeq[0]}");
                    if (count == 10) { Console.Write(" Jackpot!"); }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"ticket \"{t}\" - no match");
                }
            }
        }
    }

    private static string FindMaxEqualSeq(string s)
    {
        var bestStr = "" + s[0];
        var max = 1;
        for (int i = 0; i < s.Length-1; i++)
        {
            var ch = s[i];
            var count = 1;
            while (i + count < s.Length && s[i + count] == s[i])
            {
                count++;
                if (count>max)
                {
                    max = count;
                    bestStr = s.Substring(i, count);
                }
            }
               
        }
        return bestStr;
    }
}

