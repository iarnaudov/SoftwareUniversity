using System;

class Program
{
    static void Main()
    {
        int z = int.Parse(Console.ReadLine());
        int ThirdNum = z % 10;
        int SecondNum = z % 100 / 10;
        int FirstNum = z % 1000 / 100;
        int n = FirstNum + SecondNum;
        int m = FirstNum + ThirdNum;
        int sum = 0;

        

      
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (z % 5 == 0)
                {
                    sum = z - FirstNum;
                    z = sum;
                }
                else if (z % 3 == 0)
                {
                    sum = z - SecondNum;
                    z = sum;
                }
                else
                {
                    sum = z + ThirdNum;
                    z = sum;
                }
                Console.Write("{0} ", sum);

            }
            Console.WriteLine();
        }



    }
}
