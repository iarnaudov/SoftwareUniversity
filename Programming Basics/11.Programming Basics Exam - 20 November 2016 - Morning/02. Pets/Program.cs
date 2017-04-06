using System;

class Program
{
    static void Main()
    {
        int dni = int.Parse(Console.ReadLine());
        int ostavenahrana = int.Parse(Console.ReadLine());
        double kuchehrana = double.Parse(Console.ReadLine());
        double kotkahrana = double.Parse(Console.ReadLine());
        double kostenurkagram = double.Parse(Console.ReadLine());
        double kostenurkahrana = kostenurkagram / 1000;
        double TotalHranaNeeded = 0;

        TotalHranaNeeded = (kuchehrana + kotkahrana + kostenurkahrana) * dni;
        if (ostavenahrana>=TotalHranaNeeded)
        {
            Console.WriteLine("{0:0} kilos of food left.",Math.Floor(ostavenahrana-TotalHranaNeeded));
        }
        else
        {
            Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(TotalHranaNeeded-ostavenahrana));
        }

    }
}
