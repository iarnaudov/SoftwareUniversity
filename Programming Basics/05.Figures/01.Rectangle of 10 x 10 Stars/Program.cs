using System;

class Program
{
    static void Main()
    {
        for (int row = 0; row < 10; row++)
        {
            for (int col = 0; col < 10; col++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }
    }
}
