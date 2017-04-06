using System;

class Program
{
    static void Main()
    {


        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int MagicalNum = int.Parse(Console.ReadLine());
        int combination = 0;


        for (int i = n; i <= m; i++)
        {
            for (int j = n; j <= m; j++)
            {
                combination++;
                Console.Write("", i, j);
                if (i + j == MagicalNum)
                {

                    Console.WriteLine("Combination N:{0} ({1} + {2} = {3})", combination, i, j, MagicalNum);
                    return;
                }
                if (i+j!=MagicalNum)
                {
                    
                }

            }

        }
        Console.WriteLine("{0} combinations - neither equals {1}", combination, MagicalNum);

    }
}
