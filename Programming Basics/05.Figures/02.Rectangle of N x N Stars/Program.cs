using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int row = 0; row < n; row++)
        {
            string m = new string('*', n);
            Console.WriteLine(m);
        }
    }
}
