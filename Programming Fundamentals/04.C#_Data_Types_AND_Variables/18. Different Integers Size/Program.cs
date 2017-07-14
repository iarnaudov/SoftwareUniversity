using System;

class Program
{
    static void Main()
    {

            try
            {
                decimal n = decimal.Parse(Console.ReadLine());
                if (n <= 9223372036854775807)
                {

                    Console.WriteLine($"{n} can fit in:");
                    if (-128 <= n && n <= 127) { Console.WriteLine("* sbyte"); }
                    if (0 <= n && n <= 255) { Console.WriteLine("* byte"); }
                    if (-32768 <= n && n <= 32767) { Console.WriteLine("* short"); }
                    if (0 <= n && n <= 65535) { Console.WriteLine("* ushort"); }
                    if (-2147483648 <= n && n <= 2147483647) { Console.WriteLine("* int"); }
                    if (0 <= n && n <= 4294967295) { Console.WriteLine("* uint"); }
                    if (-9223372036854775808 <= n && n <= 9223372036854775807) { Console.WriteLine("* long"); }
                }
                else
                {
                    Console.WriteLine($"{n} can't fit in any type");
                }
            }
            catch (System.FormatException)
            {

                Console.WriteLine("not a number");
            }

      
    

    }
}

