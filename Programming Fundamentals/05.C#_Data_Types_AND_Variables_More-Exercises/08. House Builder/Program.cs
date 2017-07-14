using System;

class Program
{
    static void Main()
    {
        long TotalPrice = 0;
        long sbytePrice = 0;
        long intPrice = 0;

        for (int i = 0; i < 2; i++)
        {
            long price = long.Parse(Console.ReadLine());
       
            if (price <= 127)
            {
                 sbytePrice = 4 * price;
            }
            else if (price >= 128 && price <= 2147483647)
            {
                 intPrice = 10 * price;
            }
            TotalPrice = sbytePrice + intPrice;
        }
        Console.WriteLine(TotalPrice);
        
      




    }
}

