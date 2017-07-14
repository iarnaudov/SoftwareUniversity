using System;

class Program
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        string diagonalType = Console.ReadLine();
        Console.WriteLine($"{PrintResult(n,diagonalType):f2}");
    }

    private static double PrintResult(double n, string diagonalType)
    {
        double result = 0;
        switch (diagonalType)
        {
            case "face":
                result = Math.Sqrt(2 * Math.Pow(n, 2)); break;
            case "space": 
                result = Math.Sqrt(3 * Math.Pow(n, 2)); break;
            case "volume":
                result = Math.Pow(n, 3); break;
            case "area":
                result = 6 * Math.Pow(n, 2); break;

            default:
                break;
        }
        return result;
    }
}

