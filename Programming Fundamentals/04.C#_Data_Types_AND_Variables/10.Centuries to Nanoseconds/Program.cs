using System;

class Program
{
    static void Main()
    {

        int century = int.Parse(Console.ReadLine());
        int year = century * 100;
        int days = (int)Math.Floor(year * 365.2422);
        int hours = days * 24;
        int minutes = hours * 60;
        long seconds = (long)minutes * 60;
        long milisecs = (long)seconds * 1000;
        ulong microsecs = (ulong)milisecs * 1000;
        ulong nanosecs = microsecs * 1000;


        Console.WriteLine($"{century} centuries = {year} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milisecs} milliseconds = {microsecs} microseconds = {microsecs}000 nanoseconds");





    }
}

