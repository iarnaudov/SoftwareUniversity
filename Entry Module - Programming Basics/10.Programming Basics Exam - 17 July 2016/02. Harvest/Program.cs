using System;

class Program
{
    static void Main()
    {

        int LozeKvm = int.Parse(Console.ReadLine());
        double GrozdeKvM = double.Parse(Console.ReadLine());
        int VinoLt = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());

        double TotalGrozde = LozeKvm * GrozdeKvM;
        double TotalVino = (TotalGrozde/2.5) * 0.4;

        if (TotalVino>=VinoLt)
        {
            Console.WriteLine("Good harvest this year! Total wine: {0} liters.",Math.Floor( TotalVino));
            Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(TotalVino-VinoLt),Math.Ceiling( (TotalVino - VinoLt) / workers));
        }
        else
        {
            Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(VinoLt - TotalVino));       
        }














    }
}
