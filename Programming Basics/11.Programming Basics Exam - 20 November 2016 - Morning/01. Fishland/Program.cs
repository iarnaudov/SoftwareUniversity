using System;

class Program
{
    static void Main()
    {
        double skumriq = double.Parse(Console.ReadLine());
        double caca = double.Parse(Console.ReadLine());
        double palamudkg = double.Parse(Console.ReadLine());
        double safridkg = double.Parse(Console.ReadLine());
        double midikg = double.Parse(Console.ReadLine());
        double PalamudPrice = 0;
        double SafridPrice = 0;
        double MidiPrice = 0;
        double TotalPrice = 0;
        //---------------------------
        PalamudPrice = palamudkg* (skumriq*1.60);
        SafridPrice = safridkg * (caca * 1.80);
        MidiPrice = midikg * 7.50;

        TotalPrice = PalamudPrice + SafridPrice + MidiPrice;
        Console.WriteLine("{0:f2}",TotalPrice);

    }
}
