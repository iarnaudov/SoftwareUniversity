using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var separators = new char[]
        {
            ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[', ']', ' '
        };
        var words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
        var lowerCaseList = new List<string>();
        var upperCaseList = new List<string>();
        var mixedCaseList = new List<string>();

        foreach (var w in words)
        {
            var type = GetWordType(w);
            if (type == WordType.Uppercase) upperCaseList.Add(w);
            if (type == WordType.Lowercase) lowerCaseList.Add(w);
            if (type == WordType.Mixedcase) mixedCaseList.Add(w);
        }
        Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCaseList));
        Console.WriteLine("mixed-case: {0}", string.Join(", ", mixedCaseList));
        Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCaseList));
       
    }
    enum WordType { Uppercase, Mixedcase, Lowercase }

    static WordType GetWordType(string word)
    {
        var lowerLetters = 0;
        var upperLetters = 0;
        foreach (var l in word)
        {
            if (char.IsUpper(l)) {upperLetters++;}
            else if (char.IsLower(l)) { lowerLetters++; }
        }
        if (upperLetters==word.Length) return WordType.Uppercase;
        if (lowerLetters == word.Length) return WordType.Lowercase;
        return WordType.Mixedcase;


    }
    
}

