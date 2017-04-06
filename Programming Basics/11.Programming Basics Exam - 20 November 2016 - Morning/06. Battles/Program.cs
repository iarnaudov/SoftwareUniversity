using System;

class Program
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int number = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= m; j++)
            {             
                if (counter>=number)
                {
                    Console.WriteLine();
                    return;
                }
                Console.Write("({0} <-> {1}) ", i, j);
                counter++;
            }
        }
       

    }
}
