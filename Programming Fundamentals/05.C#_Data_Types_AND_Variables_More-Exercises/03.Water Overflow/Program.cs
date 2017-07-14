using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int counter = 0;
        for (int i = 0; i < n; i++)
        {
            int litersPoured = int.Parse(Console.ReadLine());
            counter += litersPoured;
            if (counter>255)
            {
                Console.WriteLine("Insufficient capacity!");
                counter -= litersPoured;
                
            }
        }
        Console.WriteLine(counter);



    }
}

