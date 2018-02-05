using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03._WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var textFile = @"..\source\text.txt";
            var wordsFile = @"..\source\words.txt";
            var outputFile = @"..\source\results.txt";

            using (var stream = new StreamReader(textFile))
            {
                using (var wordsStream = new StreamReader(wordsFile))
                {
                    var totalWords = stream.ReadToEnd().Split(new[] { ' ', '\r', '\n','-','?','!','.', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(a => a.ToLower()).ToArray();
                    var words = wordsStream.ReadToEnd().Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    var dict = new Dictionary<string, int>();
                    
                    using (var streamWriter = new StreamWriter(outputFile))
                    {
                        foreach (var word in totalWords)
                        {
                            if (words.Contains(word))
                            {
                                if (!dict.ContainsKey(word))
                                {
                                    dict.Add(word, 0);
                                }

                                dict[word]++;
                            }
                        }
                        var sortedDict = dict.OrderByDescending(d => d.Value).ToArray();
                        foreach (var item in sortedDict)
                        {
                            streamWriter.WriteLine($"{item.Key} - {item.Value}");
                        }
                    }
                }
               

            }
        }
    }
}
