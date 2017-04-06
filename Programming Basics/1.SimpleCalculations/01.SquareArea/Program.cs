using System;

namespace SquareArea
{
    class SquareArea
    {
        static void Main()
        {
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            int square = a * a;
            Console.WriteLine("The Square Area is: {0}", square);

        }
    }
}
