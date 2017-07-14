using System;

class Program
{
    static void Main()
    {
        string unit = Console.ReadLine();
        double quantity = double.Parse(Console.ReadLine());

        switch (unit)
        {
            case "miles": Console.WriteLine("{0} {1} = {2:f2} kilometers", quantity,unit,quantity*1.60); break;
            case "inches": Console.WriteLine("{0} {1} = {2:f2} centimeters", quantity, unit, quantity * 2.54); break;
            case "feet": Console.WriteLine("{0} {1} = {2:f2} centimeters", quantity, unit, quantity * 30); break;
            case "yards": Console.WriteLine("{0} {1} = {2:f2} meters", quantity, unit, quantity * 0.91); break;
            case "gallons": Console.WriteLine("{0} {1} = {2:F2} liters", quantity, unit, quantity * 3.80); break;
            default:
                break;
        }




    }
}

