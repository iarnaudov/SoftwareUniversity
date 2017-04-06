using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        // TODO: First Row
        Console.Write("+");
        for (int i = 0; i < n-2; i++){Console.Write(" -"); }
        Console.WriteLine(" +");

        // TODO: Middle Rows
        for (int i = 0; i < n-2; i++)
        {
            Console.Write("|");
            for (int j = 0; j < n - 2; j++) {Console.Write(" -");}
            Console.WriteLine(" |");
        }
          // TODO: First/Last Row
        Console.Write("+");
        for (int i = 0; i < n - 2; i++) { Console.Write(" -");}
        Console.WriteLine(" +");
    }
}
