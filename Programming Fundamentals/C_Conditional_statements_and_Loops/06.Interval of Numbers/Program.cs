using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        if (n > m)
        {
            for (int i = m; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
        else if (n < m)
        {
            for (int i = n; i <= m; i++)
            {
                Console.WriteLine(i);
            }
        }


    }
}

