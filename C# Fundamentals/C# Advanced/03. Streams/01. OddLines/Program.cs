using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace _01._OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = @"..\source\text.txt";

            using (var stream = new StreamReader(file))
            {
                var lines = stream.ReadToEnd().Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int i = 0; i < lines.Length; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine(lines[i]);
                    }
                }
            }
        }
    }
}
