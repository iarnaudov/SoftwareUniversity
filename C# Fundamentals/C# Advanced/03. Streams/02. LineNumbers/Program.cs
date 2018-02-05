using System;
using System.IO;
using System.Linq;

namespace _02._LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = @"..\source\text.txt";
            var outputFile = @"..\source\02.Output.txt";

            using (var stream = new StreamReader(file))
            {
                var lines = stream.ReadToEnd().Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                using (var streamWriter = new StreamWriter(outputFile))
                {
                    for (int i = 1; i <= lines.Length; i++)
                    {
                        streamWriter.WriteLine($"Line {i}: {lines[i-1]}");
                    }
                }
               
            }
        }
    }
}
