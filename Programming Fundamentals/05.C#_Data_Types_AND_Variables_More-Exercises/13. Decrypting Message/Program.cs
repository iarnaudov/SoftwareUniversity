using System;

class Program
{
    static void Main()
    {
        int key = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            char letter = char.Parse(Console.ReadLine());
            Console.Write(Convert.ToChar(letter+key));
        }

        Console.WriteLine();
    }
}

