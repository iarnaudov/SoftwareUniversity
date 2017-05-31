using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int kcal = 0;
        string product="";
        for (int i = 0; i < n; i++)
        {
            product = Console.ReadLine().ToLower();
            switch (product)
            {
                case "cheese": kcal += 500; break;
                case "tomato sauce": kcal += 150; break;
                case "salami": kcal += 600; break;
                case "pepper": kcal += 50; break;

                default:
                    continue;
            }
        }
        Console.WriteLine($"Total calories: {kcal}");
    }
}

