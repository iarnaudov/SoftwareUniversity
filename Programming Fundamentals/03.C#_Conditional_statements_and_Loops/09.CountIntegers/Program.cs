using System;

class Program
{
    static void Main()
    {
        int counter = 0;
        do
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                counter++;

            }
            catch (Exception)
            {
                Console.WriteLine(counter);
                break;
            
            }
        } while (true);
       






    }
}

