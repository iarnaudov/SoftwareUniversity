using System;

class Program
{
    static void Main()
    {

        string Month = Console.ReadLine();
        int num = int.Parse(Console.ReadLine());
        double studio = 0;
        double apart = 0;

        switch (Month)
        {
            case "May":
            case "October":
                 studio = num * 50.00;
                 apart = num * 65;
                if (num > 7 && num<=14) studio = studio * 0.95 ;
                else if (num > 14) studio = studio * 0.7;
                if (num > 14) apart = apart * 0.90; break;

            case "June":
            case "September":
                studio = num * 75.20;
                apart = num * 68.70;
                if (num > 14) apart = apart * 0.90;
                if (num > 14) studio = studio * 0.8; break;

            case "July":
            case "August":
                studio = num * 76;
                apart = num * 77;
                if (num > 14) apart = apart * 0.90; break;

                
            default: break;
        }


        Console.WriteLine("Apartment: {0:f2} lv.", apart);
        Console.WriteLine("Studio: {0:f2} lv.", studio);














    }
}
