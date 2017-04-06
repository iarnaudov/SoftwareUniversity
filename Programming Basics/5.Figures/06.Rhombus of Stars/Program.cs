using System;

class Program
{
    public static object ReadAllLines { get; private set; }

    static void Main()
    {
        int n = 5;

        //първи ред
        Console.Write(new string(' ', n / 2));
        Console.Write('*');
        Console.WriteLine(new string(' ', n / 2));

        //upper rows
        for (var row = 1; row <= (n/2)+1; row++)
        {
            for (int col = 0; col < n-row; col++)
            {
                Console.Write(new string (' ',(n/2)));
                Console.WriteLine(new string('*', (n / 2)));

            }



        }


        //последен ред
        Console.Write(new string(' ', n / 2));
        Console.Write('*');
        Console.WriteLine(new string(' ', n / 2));
    }
}
