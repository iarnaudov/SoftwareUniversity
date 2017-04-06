using System;

class Program
{
    static void Main()
    {
        double MoneySaved = double.Parse(Console.ReadLine());
        double FloorWidth = double.Parse(Console.ReadLine());
        double FloorLenght = double.Parse(Console.ReadLine());
        double TriangleSide = double.Parse(Console.ReadLine());
        double TriangleHeight = double.Parse(Console.ReadLine());
        double TilePrice = double.Parse(Console.ReadLine());
        double MasterPrice = double.Parse(Console.ReadLine());
        //----------------------------------------------------------------------

        double FloorSize = FloorLenght * FloorWidth;
        double TileSize = TriangleSide * TriangleHeight / 2;
        double TilesNeeded = Math.Ceiling(FloorSize / TileSize);
        double TotalTiles = TilesNeeded + 5;
        double TotalSum = TotalTiles * TilePrice + MasterPrice;

        if (MoneySaved >= TotalSum)
        {
            Console.WriteLine("{0:f2} lv left.", MoneySaved - TotalSum);
        }
        else
        {
            Console.WriteLine("You'll need {0} lv more.", TotalSum - MoneySaved);
        }

    }
}
