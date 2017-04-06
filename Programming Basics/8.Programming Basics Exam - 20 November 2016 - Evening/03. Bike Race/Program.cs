using System;

class Program
{
    static void Main()
    {
        int juniors = int.Parse(Console.ReadLine());
        int seniors = int.Parse(Console.ReadLine());
        string track = Console.ReadLine();
        double juniorTax = 0;
        double seniorTax = 0;
        double TotalTax = 0;

        switch (track)
        {
            case "trail":
                {
                    juniorTax = juniors * 5.50;
                    seniorTax = seniors * 7;
                    TotalTax = (juniorTax + seniorTax) * 0.95; break;
                }

            case "cross-country":
                {
                    juniorTax = juniors * 8.0; 
                    seniorTax = seniors * 9.50;
                    TotalTax = juniorTax + seniorTax;
                    if ((juniors + seniors) >= 50) TotalTax *=0.75;
                    TotalTax *=0.95; break;
                }

            case "downhill":
                {
                    juniorTax = juniors * 12.25; 
                    seniorTax = seniors * 13.75; 
                    TotalTax = (juniorTax + seniorTax) * 0.95; break;
                }
            case "road":
                {
                    juniorTax = juniors * 20; 
                    seniorTax = seniors * 21.50;
                    TotalTax = (juniorTax + seniorTax) * 0.95; break;
                }
            
        }
        Console.WriteLine("{0:f2}", TotalTax);

    }
}
