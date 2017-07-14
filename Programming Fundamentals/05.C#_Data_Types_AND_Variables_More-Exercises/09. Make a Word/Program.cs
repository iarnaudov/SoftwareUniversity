using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.Write("The word is: ");
        for (int i = 0; i < n; i++)
        {
            char letter = char.Parse(Console.ReadLine());
            Console.Write(letter);
        }




    }
}

