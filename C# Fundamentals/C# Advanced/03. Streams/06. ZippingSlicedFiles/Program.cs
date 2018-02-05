using System;
using System.IO;
using System.IO.Compression;

namespace _06._ZippingSlicedFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            int partsCount = 5;
            string sourceFile = @"..\source\sliceMe.mp4";
            string destinationDirectory = @"..\source\";

            SliceAndZip(sourceFile, destinationDirectory, partsCount);
        }

        private static void SliceAndZip(string sourceFile, string destinationDirectory, int partsCount)
        {

            var buffer = new byte[4096];

            using (var source = new FileStream(sourceFile, FileMode.Open))
            {
                using (var reader = new FileStream(sourceFile, FileMode.Open))
                {
                    string extension = sourceFile.Substring(sourceFile.LastIndexOf('.') + 1);

                    long pieceSize = (long)Math.Ceiling((double)reader.Length / partsCount);

                    long currentPieceSize = 0;

                    for (int i = 0; i < partsCount; i++)
                    {
                        destinationDirectory = destinationDirectory == string.Empty ? "./" : destinationDirectory;

                        string currentPath = destinationDirectory + $"Part-{i}.{extension}.gz";

                        using (GZipStream writer = new GZipStream(new FileStream(currentPath, FileMode.Create),CompressionLevel.Optimal))
                        {

                            while (reader.Read(buffer, 0, 4096) == 4096)
                            {
                                writer.Write(buffer, 0, 4096);
                                currentPieceSize += 4096;

                                if (currentPieceSize >= pieceSize)
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
