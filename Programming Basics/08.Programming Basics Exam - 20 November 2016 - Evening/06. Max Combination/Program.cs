using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int MaxCombination = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int i = n; i <= m; i++)
        {
            for (int j = n; j <= m; j++)
            {
                counter++;
                Console.Write("<{0}-{1}>", i,j);
                
                if (counter>=MaxCombination)
                {
                    
                    return;
                }

            }
           
        }
        Console.WriteLine();
    }
}
