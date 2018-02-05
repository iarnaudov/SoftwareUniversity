using System;
using System.IO;

namespace _04._CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new FileStream(@"..\source\copyMe.png", FileMode.Open))
            {
                using (var writer = new FileStream(@"..\source\newCopied.png", FileMode.Create))
                {
                    byte[] buffer = new byte[4096];

                    while (true)
                    {
                        int readBytes = reader.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }
                        writer.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }
}
