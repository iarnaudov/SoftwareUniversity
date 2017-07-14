using System;

class Program
{
    static void Main()
    {
        double balance = double.Parse(Console.ReadLine());
        string game = "";
        double totalsum = 0;

        do
        {
            game = Console.ReadLine();
            switch (game)
            {
                case "OutFall 4":
                    if (balance >= 39.99)
                    {
                        balance -= 39.99;
                        Console.WriteLine($"Bought OutFall 4");
                        totalsum += 39.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    break;

                case "CS: OG":
                    if (balance >= 15.99)
                    {
                        balance -= 15.99;
                        Console.WriteLine($"Bought CS: OG");
                        totalsum += 15.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    break;
                case "Zplinter Zell":
                    if (balance >= 19.99)
                    {
                        balance -= 19.99;
                        Console.WriteLine($"Bought Zplinter Zell");
                        totalsum += 19.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    break;
                case "Honored 2":
                    if (balance >= 59.99)
                    {
                        balance -= 59.99;
                        Console.WriteLine($"Bought Honored 2");
                        totalsum += 59.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    break;
                case "RoverWatch":
                    if (balance >= 29.99)
                    {
                        balance -= 29.99;
                        Console.WriteLine($"Bought RoverWatch");
                        totalsum += 29.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    break;
                case "RoverWatch Origins Edition":
                    if (balance >= 39.99)
                    {
                        balance -= 39.99;
                        Console.WriteLine($"Bought RoverWatch Origins Edition");
                        totalsum += 39.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    break;
                default:
                    if (game != "Game Time")
                    {
                        Console.WriteLine("Not Found");
                    }
                    continue;

            }

            if (balance<=0)
            {
                Console.WriteLine("Out of money!");
            }

        } while (game != "Game Time");

        Console.WriteLine($"Total spent: ${totalsum:f2}. Remaining: ${balance:f2}");




    }
}

