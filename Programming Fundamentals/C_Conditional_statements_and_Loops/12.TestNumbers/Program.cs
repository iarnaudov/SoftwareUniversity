using System;

class Program
{
    static void Main()
    {

        var n = int.Parse(Console.ReadLine());
        var m = int.Parse(Console.ReadLine());
        var maxsum = int.Parse(Console.ReadLine());
        var sum = 0;
        var TotalCombinations = 0;
        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= m; j++)
            {
             
                var number = (i * j) * 3;
                sum += number;
                TotalCombinations++;
                if (sum >= maxsum)
                {
                    Console.WriteLine($"{TotalCombinations} combinations");
                    Console.WriteLine($"Sum: {sum} >= {maxsum}");
                    return;
                }

            }
        }
        Console.WriteLine($"{TotalCombinations} combinations");
        Console.WriteLine($"Sum: {sum}");


    }
}

