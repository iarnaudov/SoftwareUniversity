using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
           
        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < n-1; j++)
            {
                Console.Write("* ");
            }
            Console.Write("*");
            Console.WriteLine();
        }
    }
}
