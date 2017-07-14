using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;


class Program
{
    static void Main()
    {

        string[] words =
  File.ReadAllText("words.txt").ToLower().Split();
        string[] text = File.ReadAllText("input.txt").ToLower()
          .Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' },
           StringSplitOptions.RemoveEmptyEntries);
        var wordCount = new Dictionary<string, int>();
        foreach (string word in words)
            wordCount[word] = 0;
        foreach (string word in text)
            if (wordCount.ContainsKey(word))
                wordCount[word]++;

       var sorted =  wordCount.OrderByDescending(a => a.Value).ToArray();

       // foreach (var item in sorted)
        //{
            File.WriteAllLines("myfile.txt",
     sorted.Select(x => x.Key + " " + "-" +" "+ x.Value).ToArray());
        //}
       



    }
}

