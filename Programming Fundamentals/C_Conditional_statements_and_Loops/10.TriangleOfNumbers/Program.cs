using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int count = 1;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (count <= n)
                {

                    Console.Write(count + " ");
                   
                }
                else
                {
                    break;
                }
            }
            count++;
            Console.WriteLine();
        }
    }
}
