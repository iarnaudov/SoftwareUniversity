using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); ;
        double totalTonaj = 0;
        double Sum = 0;
        double Totalsum = 0;
        double AveragePrice = 0;
        double tonaj=0;
        double counterMikrobus = 0;
        double counterKamion = 0;
        double counterVlak = 0;

        for (int i = 0; i < n; i++)
        {
            tonaj = int.Parse(Console.ReadLine());
            if (tonaj <= 3) { Sum = tonaj * 200;counterMikrobus+=tonaj; totalTonaj += tonaj; Totalsum += Sum; }
            else if (tonaj <= 11) { Sum = tonaj * 175; counterKamion += tonaj; totalTonaj += tonaj; Totalsum += Sum; }
            else if (tonaj >= 12) { Sum = tonaj * 120; counterVlak += tonaj; totalTonaj += tonaj; Totalsum += Sum; }
           

        }
        Console.WriteLine("{0:f2}", Totalsum / totalTonaj);
        Console.WriteLine("{0:0.00%}",counterMikrobus/totalTonaj);
        Console.WriteLine("{0:0.00%}", counterKamion / totalTonaj);
        Console.WriteLine("{0:0.00%}", counterVlak / totalTonaj);


    }



    
}
