using System;

class Program
{
    static void Main()
    {
        double numGroups = double.Parse(Console.ReadLine());

        double kola = 0;
        double mikrobus =0;
        double malukAvtobus = 0;
        double golqmAvtobus = 0;
        double vlak = 0;



        for (int i = 0; i < numGroups; i++)
        {
            double numPeople =double.Parse(Console.ReadLine());
            if (numPeople <= 5) kola+=numPeople;
            else if (numPeople >= 6 && numPeople <= 12) mikrobus+=numPeople;
            else if (numPeople >= 13 && numPeople <= 25) malukAvtobus+= numPeople;
            else if (numPeople >= 26 && numPeople <= 40) golqmAvtobus+= numPeople;
            else if (numPeople >= 41) vlak+= numPeople;
           
        }
        double TotalPeople = kola + mikrobus + malukAvtobus + golqmAvtobus + vlak ;

        Console.WriteLine("{0:0.00%}",kola/TotalPeople);
        Console.WriteLine("{0:0.00%}", mikrobus / TotalPeople);
        Console.WriteLine("{0:0.00%}", malukAvtobus / TotalPeople);
        Console.WriteLine("{0:0.00%}", golqmAvtobus / TotalPeople);
        Console.WriteLine("{0:0.00%}", vlak / TotalPeople);

    }
}
