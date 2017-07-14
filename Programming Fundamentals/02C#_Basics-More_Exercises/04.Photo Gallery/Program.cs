using System;

class Program
{
    static void Main()
    {

        
        int number = int.Parse(Console.ReadLine());
           int day = int.Parse(Console.ReadLine());
         int month = int.Parse(Console.ReadLine());
          int year = int.Parse(Console.ReadLine());
          int hour = int.Parse(Console.ReadLine());
       int minutes = int.Parse(Console.ReadLine());
       double size = double.Parse(Console.ReadLine());
         int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());


        Console.WriteLine($"Name: DSC_{number:d4}.jpg");
        Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year:d4} {hour:d2}:{minutes:d2}");

        if (size < 1000){Console.WriteLine($"Size: {size}B");}
        else if (size < 1000000) {Console.WriteLine("Size: {0}KB", size / 1000);}
        else if (size >= 1000000) {Console.WriteLine("Size: {0}MB", size / 1000000);}

        if (width>height){Console.WriteLine($"Resolution: {width}x{height} (landscape)");}
        else if (width < height) {Console.WriteLine($"Resolution: {width}x{height} (portrait)");}
        else if (width == height){Console.WriteLine($"Resolution: {width}x{height} (square)");}
    }
}

