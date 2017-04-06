using System;

class Program
{
    static void Main()
    {

        double a = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        // 2 strani
        double sides = a * (a / 2) * 2;

        //back side
        double square = (a / 2) * (a / 2);
        double triangle = (a / 2.0 * (h - a / 2.0)) / 2.0;
        double backside = square + triangle;

        //frond side

        double entry = (a / 5.0) * (a / 5.0);
        double frontside = backside - entry;
        double TotalSquare = sides + backside + frontside;
        double green = TotalSquare / 3;
        //Pokriv 
        double pokriv = a * (a / 2) * 2;
        double red = pokriv / 5;


        Console.WriteLine("{0:f2}",green);
        Console.WriteLine("{0:f2}",red);















    }
}
