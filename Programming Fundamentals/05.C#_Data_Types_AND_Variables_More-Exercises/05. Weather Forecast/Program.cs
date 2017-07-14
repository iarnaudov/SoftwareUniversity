using System;

class Program
{
    static void Main()
    {

        try
        {
            long n = long.Parse(Console.ReadLine());
            if (sbyte.MinValue <= n && n <= sbyte.MaxValue)
            {
                Console.WriteLine("Sunny");
            }
          else  if (int.MinValue <= n && n <= int.MaxValue)
            {
                Console.WriteLine("Cloudy");
            }
            else if (long.MinValue <= n && n <= long.MaxValue)
            {
                Console.WriteLine("Windy");
            }
  

        }
        catch (FormatException)
        {

            Console.WriteLine("Rainy"); 
        }



    }
}

