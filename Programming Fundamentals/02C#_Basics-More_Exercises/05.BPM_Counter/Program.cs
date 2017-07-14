using System;

class Program
{
    static void Main()
    {
        double bpm = double.Parse(Console.ReadLine());
        double numberofbeats = double.Parse(Console.ReadLine());

        double time = numberofbeats/(bpm / 60);
       double minutes = (int)time / 60;
       double seconds = (int)time % 60;
        Console.WriteLine($"{Math.Round(numberofbeats / 4, 1)} bars - {minutes}m {seconds}s");




    }
}

