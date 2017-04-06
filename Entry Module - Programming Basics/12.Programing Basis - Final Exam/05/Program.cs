using System;

class Program
{
    static void Main()
    {


        int n = int.Parse(Console.ReadLine());
        int counterdiez = 1;
        int diez = 0;


        // ширина на реда -------- 12 * n - 5
        // височина на картинката -- 4 * n - 2 

        // горната част на картинката

        for (int i = 0; i < n*2; i++)
        {
            
            double dots = Math.Ceiling((12 * n - 5) / 2.0) - Math.Ceiling(counterdiez / 2.0);
            Console.Write(new string('.', (int)dots));
            Console.Write(new string('#', counterdiez));
            Console.Write(new string('.', (int)dots));
            counterdiez += 6;
            Console.WriteLine();

        }
        

        //долната част на картинката

        for (int i = 0; i < n-2; i++)
        {
            int dots = 2;
            Console.Write("|");
            Console.Write(new string ('.', dots+diez/2));
            Console.Write(new string('#', (12 * n - 5) -(2* dots)-2-diez));
            Console.Write(new string('.', dots+1+diez/2));
            Console.WriteLine();
            dots = dots * 3;
            diez = diez + 6;
        }

        //дъно

        for (int i = 1; i <= n; i++)
        {
            if (i>=1 && i <n)
            {
                int dots = n * 3 - 3;
                Console.Write("|");
                Console.Write(new string('.', dots - 1));
                Console.Write(new string('#', (12 * n - 5) - (2 * dots)));
                Console.Write(new string('.', dots));
                Console.WriteLine();
            }
            else
            {
                int dots = n * 3 - 3;
                Console.Write("@");
                Console.Write(new string('.', dots - 1));
                Console.Write(new string('#', (12 * n - 5) - (2 * dots)));
                Console.Write(new string('.', dots));
                Console.WriteLine();
            }
           

        }










    }
}
