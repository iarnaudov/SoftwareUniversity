using System;

class Program
{
    static void Main()
    {


        int n = int.Parse(Console.ReadLine());
        int width = 5 * n;

        for (int i = 0; i < n; i++)
        {
            
            {
                Console.Write(new string('-', 3 * n));
                Console.Write("*");
                Console.Write(new string('-', i));
                Console.Write("*");
                Console.Write(new string('-', width - (3 * n) - 1-1 - i));
                Console.WriteLine();
            }


          }
        for (int i = 0; i < n / 2; i++)
        {

            Console.Write(new string('*', n * 3 + 1));
            Console.Write(new string('-', n-1));
            Console.Write("*");
            Console.WriteLine(new string('-', n-1));
        }

        for (int i = 0; i <= (n/2-1); i++)
        {
            if (i < (n / 2 - 1))
            {
                int end = 1 + i;
                Console.Write(new string('-', 3 * n - i));
                Console.Write("*");
                Console.Write(new string('-', n - 1 + i * 2));
                Console.Write("*");
                Console.WriteLine(new string('-', width - (3 * n - i) - (n - 1 + i * 2) - 2));
            }
            
            else if (i== (n / 2 - 1))
            {
                Console.Write(new string('-', 3 * n - i));
                Console.Write("*");
                Console.Write(new string('*', n - 1 + i * 2));
                Console.Write("*");
                Console.WriteLine(new string('-', width - (3 * n - i) - (n - 1 + i * 2) - 2));
            }

        }
      









    }
}
