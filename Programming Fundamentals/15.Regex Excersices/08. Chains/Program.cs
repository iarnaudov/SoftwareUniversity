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
        var paragraphRegex = new Regex(@"<p>(?<message>.+?)<\/p>");
        var text = Console.ReadLine();

        var parahraphs = paragraphRegex.Matches(text)
        .Cast<Match>()
        .Select(a => a.Groups["message"].Value)
        .Select(a => Regex.Replace(a, @"[^a-z\d]+", " "))
        .Select(a => Regex.Replace(a, @"\s+", " "))
        .ToArray();

        for (int i = 0; i < parahraphs.Length; i++)
        {
            parahraphs[i] = Rot13String(parahraphs[i]);
        }
        var result = new StringBuilder();
        foreach (var paragraph in parahraphs)
        {
            result.Append(paragraph);
        }
        Console.WriteLine(result);




    }
    private static string Rot13String(string input)
    {
        var result = new StringBuilder();
        foreach (var letter in input)
        {
            result.Append(Rot13(letter));
        }
        return result.ToString();
    }

    private static char Rot13(char letter)
    {
        if (!char.IsLetter(letter))
        {
            return letter;
        }
        var offset = char.IsUpper(letter) ? 'A' : 'a';
        var rotatedLetter = (char)((((letter - offset)+13) % 26)+offset);
        return rotatedLetter;
    }
}

