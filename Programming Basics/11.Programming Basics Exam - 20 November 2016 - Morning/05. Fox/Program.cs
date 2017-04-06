using System;

class Program
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int counter = 1;
        int count = 0;
        int con =1;
        // Горна част
        for (int i = 1; i <= n; i++)
        {
            int dashes = 2 * n - counter;
            Console.Write(new string('*', i));
            Console.Write('\\');
            Console.Write(new string('-', dashes));
            Console.Write('/');
            Console.WriteLine(new string('*', i));
            counter += 2;

        }
        //средна част
        count = 0;
        for (int i = 0; i < n / 3; i++)
        {
            Console.Write("|");
            Console.Write(new string('*', (n / 2) + i));
            Console.Write("\\");
            Console.Write(new string('*', n - count));
            Console.Write("/");
            Console.Write(new string('*', (n / 2) + i));
            Console.Write("|");
            Console.WriteLine();
            count += 2;
        }

        // долна част
        for (int i = 1; i <= n; i++)
        {
            int dashes = 2 * n - con;
            Console.Write(new string('-', i));
            Console.Write('\\');
            Console.Write(new string('*', dashes));
            Console.Write('/');
            Console.WriteLine(new string('-', i));
            con += 2;
        }
        



    }
}
