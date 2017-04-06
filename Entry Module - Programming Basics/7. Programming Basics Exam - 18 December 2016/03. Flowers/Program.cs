using System;

class Program
{
    static void Main()
    {

        int Hrizantemi = int.Parse(Console.ReadLine()) ;
        int Rozi = int.Parse(Console.ReadLine());
        int Lale = int.Parse(Console.ReadLine());
        string Sezon = Console.ReadLine().ToLower();
        string Praznik = Console.ReadLine().ToLower();
        //-------------------------------
        double sumCvetq = 0;
        double PriceHrizantemi = 0;
        double PriceRozi = 0;
        double PriceLaleta = 0;
        //----------------------------------
        int Obshtocvetq = Hrizantemi + Rozi + Lale ;
        if (Sezon == "spring" || Sezon == "summer")
        {
             PriceHrizantemi = Hrizantemi * 2.0;
             PriceRozi = Rozi * 4.1;
             PriceLaleta = Lale * 2.5;


        }
        else if (Sezon == "autumn" || Sezon == "winter")
        {

             PriceHrizantemi = Hrizantemi * 3.75;
             PriceRozi = Rozi * 4.5;
             PriceLaleta = Lale * 4.15;

        }

         sumCvetq = PriceHrizantemi + PriceRozi + PriceLaleta;
        //15% otstupka za praznuk
        if (Praznik == "y") sumCvetq = sumCvetq * 1.15;
        //5% otstupka za laletata
        if (Lale>7 && Sezon=="spring") sumCvetq = sumCvetq * 0.95;

        if (Rozi >= 10 && Sezon == "winter") sumCvetq = sumCvetq * 0.9;
        if (Obshtocvetq > 20) sumCvetq = sumCvetq * 0.8;

        double sumTotal = sumCvetq + 2.0;
        Console.WriteLine("{0:f2}",sumTotal);


    }
}
