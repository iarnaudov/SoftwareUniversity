using System;

class Program
{
    static void Main()
    {
        int GroupSize = int.Parse(Console.ReadLine());
        string package = Console.ReadLine().ToLower();

        if (GroupSize<=50)
        {
            switch (package)
            {
                case "normal":
                    Console.WriteLine("We can offer you the Small Hall\nThe price per person is {0:f2}$", (((2500 + 500) * 0.95) / GroupSize)); break;
                case "gold":
                    Console.WriteLine("We can offer you the Small Hall\nThe price per person is {0:f2}$", (((2500 + 750) * 0.9) / GroupSize)); break;
                case "platinum":
                    Console.WriteLine("We can offer you the Small Hall\nThe price per person is {0:f2}$", (((2500 + 1000) * 0.85) / GroupSize)); break;
                default:
                    break;
            }
        }



    }
}

