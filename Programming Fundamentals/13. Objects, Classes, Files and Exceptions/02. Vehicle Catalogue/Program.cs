using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;


class Program
{
    static void Main()
    {
        var command = Console.ReadLine().Split().ToArray();
        var allCars = new List<Cars>();
        int carsCount = 0; double sumHorsePowerCars = 0;
        int truckCount = 0; double sumHorsePowerTruck = 0;
        while (command[0] != "End")
        {
            var a = command[0];
            var carsList = new Cars()
            {
                TypeOfCar = char.ToUpper(a.First()) + a.Substring(1).ToLower(),
                Model = command[1],
                Color = command[2],
                Horsepower = double.Parse(command[3]),
            };
            allCars.Add(carsList);
            if (command[0] == "car") { carsCount++; sumHorsePowerCars += double.Parse(command[3]); }
            if (command[0] == "truck") { truckCount++; sumHorsePowerTruck += double.Parse(command[3]); }

            command = Console.ReadLine().Split().ToArray();
        }
        var modelCar = Console.ReadLine();
        while (modelCar != "Close the Catalogue")
        {
            foreach (var item in allCars)
            {
                if (modelCar == item.Model)
                {
                    Console.WriteLine($"Type: {item.TypeOfCar}{Environment.NewLine}" +
                                     $"Model: {item.Model}{Environment.NewLine}" +
                                     $"Color: {item.Color}{Environment.NewLine}" +
                                     $"Horsepower: {item.Horsepower}");
                }
            }
            modelCar = Console.ReadLine();
        }
        Console.WriteLine($"Cars have average horsepower of: {sumHorsePowerCars/carsCount:f2}.");
        Console.WriteLine($"Trucks have average horsepower of: {sumHorsePowerTruck / truckCount:f2}.");
    }
}

class Cars
{
    public string TypeOfCar { get; set; }

    public string Model { get; set; }

    public string Color { get; set; }

    public double Horsepower { get; set; }
}
