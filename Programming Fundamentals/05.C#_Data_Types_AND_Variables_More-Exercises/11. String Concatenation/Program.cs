using System;

class Program
{
    static void Main()
    {

        char connectingChar = char.Parse(Console.ReadLine());
        string oddOrEven = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        string total= "";
        string name = "";

        for (int i = 1; i <= n; i++)
        {
            name = Console.ReadLine();
            if (oddOrEven == "even" && i % 2 == 0)
            {
                 total += name + connectingChar;

            }
            else if (oddOrEven == "odd" && i % 2 != 0)
            {
                 total += name + connectingChar;

            }

        }
        Console.Write(total.Remove(total.Length - 1));

    }
}

