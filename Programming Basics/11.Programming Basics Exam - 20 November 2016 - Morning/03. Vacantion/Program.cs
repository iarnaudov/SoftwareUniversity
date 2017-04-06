using System;

class Program
{
    static void Main()
    {
        double vuzrastni = int.Parse(Console.ReadLine());
        double uchenici = int.Parse(Console.ReadLine());
        double noshtuvki = int.Parse(Console.ReadLine());
        string transport = Console.ReadLine();
        double TotalCena = 0;
       

        //---------
        double TotalPatuvashti = vuzrastni + uchenici;
        if (transport=="train" && TotalPatuvashti<50) { TotalCena = ((vuzrastni * 24.99) + (uchenici * 14.99))*2; }
        else if (transport == "train" && TotalPatuvashti >= 50) { TotalCena = (((vuzrastni * 24.99) + (uchenici * 14.99)) * 2)*0.50; }
        else if (transport == "bus") { TotalCena = ((vuzrastni * 32.50) + (uchenici * 28.50)) * 2; }
        else if (transport == "boat") { TotalCena = ((vuzrastni * 42.99) + (uchenici * 39.99)) * 2; }
        else if (transport == "airplane") { TotalCena = ((vuzrastni * 70.00) + (uchenici * 50.00)) * 2; }
        double TotalHotel = noshtuvki * 82.99;
        double commision = (TotalCena + TotalHotel) * 0.10;
        double TotalSum = TotalHotel + TotalCena + commision;
        Console.WriteLine("{0:f2}", TotalSum);

    }
}
