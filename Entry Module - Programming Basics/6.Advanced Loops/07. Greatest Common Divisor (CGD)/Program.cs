using System;

class Program
{
    static void Main()
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());

        while (A % B != 0)
        {
            int temp = A % B;
            A = B;
            B = temp;


        }
        Console.WriteLine(B);


    }
}
