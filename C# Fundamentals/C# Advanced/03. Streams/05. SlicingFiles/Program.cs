namespace _05.Slicing_File
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Program
    {

        public static void Main()
        {

            int partsCount = 5;
            string sourceFile = @"..\source\sliceMe.mp4";
            string destinationDirectory = @"..\source\";

            SliceFileIntoParts(sourceFile, destinationDirectory, partsCount);

            var files = new List<string>
            {
                @"..\source\Part-0.mp4",
                @"..\source\Part-1.mp4",
                @"..\source\Part-2.mp4",
                @"..\source\Part-3.mp4",
                @"..\source\Part-4.mp4",
            };


            AssembleFileFromParts(files, destinationDirectory);
        }

      
        private static void SliceFileIntoParts(string sourceFile, string destinationDirectory, int partsCount)
        {

            var buffer = new byte[4096];

            using (var source = new FileStream(sourceFile, FileMode.Open))
            {
                string extension = sourceFile.Substring(sourceFile.LastIndexOf('.') + 1);
                var partSize = Math.Ceiling((double)source.Length / partsCount);

                for (int index = 0; index < partsCount; index++)
                {
                    destinationDirectory = destinationDirectory == string.Empty ? "./" : destinationDirectory;

                    string currentPath = destinationDirectory + $"Part-{index}.{extension}";

                    using (var destinationFile = new FileStream(currentPath, FileMode.Create))
                    {
                        int totalBytes = 0;

                        while (totalBytes < partSize)
                        {
                            int readBytes = source.Read(buffer, 0, buffer.Length);

                            if (readBytes == 0)
                            {
                                break;
                            }

                            destinationFile.Write(buffer, 0, readBytes);
                            totalBytes += readBytes;
                        }
                    }
                }
            }
        }

        private static void AssembleFileFromParts(List<string> fileParts, string destinationDirectory)
        {
            var buffer = new byte[4096];
            string assembledFile = $"{destinationDirectory}AssembledVideo.mp4";

            using (var assembled = new FileStream(assembledFile, FileMode.Create))
            {
                foreach (var file in fileParts)
                {
                    using (FileStream reader = new FileStream(file, FileMode.Open))
                    {
                        while (true)
                        {
                            int readBytes = reader.Read(buffer, 0, buffer.Length);

                            if (readBytes == 0)
                            {
                                break;
                            }

                            assembled.Write(buffer, 0, readBytes);
                        }
                    }
                }
            }
        
        }


    }
}
