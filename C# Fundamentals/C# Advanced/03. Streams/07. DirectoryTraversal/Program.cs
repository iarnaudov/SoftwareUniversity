using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _07._DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\";
            var filesDict = new Dictionary<string, List<FileInfo>>();
            var files = Directory.GetFiles(path);

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                var extension = fileInfo.Extension;
                long size = fileInfo.Length;
                var name = fileInfo.Name;

                if (!filesDict.ContainsKey(extension))
                {
                    filesDict.Add(extension, new List<FileInfo>());
                }

                filesDict[extension].Add(fileInfo);
            }

            filesDict = filesDict
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            string fullName = desktop + "report.txt";

            using (var writer = new StreamWriter(fullName))
            {
                foreach (var item in filesDict)
                {
                    string extension = item.Key;
                    var fileInfos = item.Value.OrderByDescending(fi => fi.Length);

                    writer.WriteLine(extension);
                  
                    foreach (var fileInfo in fileInfos)
                    {
                        double fileSize = (double)fileInfo.Length / 1024;

                        writer.WriteLine($"--{fileInfo.Name} - {fileSize:F2}kb");
                    }
                   
                }
            }
        }
    }
}
