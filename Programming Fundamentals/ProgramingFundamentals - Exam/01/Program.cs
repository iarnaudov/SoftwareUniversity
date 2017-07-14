using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        int power = int.Parse(Console.ReadLine()); //N
        int distance = int.Parse(Console.ReadLine());//M
        int exhaustion = int.Parse(Console.ReadLine()); // Y
        int counter = 0;
        int powerLeft = power;

        while (powerLeft>=distance)
        {
            powerLeft = powerLeft-distance;
            counter++;
            if (powerLeft==(power*0.5) && exhaustion>0)
            {
                    powerLeft /= exhaustion;
               
            }
        }
        Console.WriteLine(powerLeft);
        Console.WriteLine(counter);
    }
}

