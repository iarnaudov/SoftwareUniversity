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
        var regex = new Regex (@"(?<city>[A-Z]{2})(?<temp>\d+\.\d+)(?<weather>[a-zA-z]+)\|");

        var cities = new Dictionary<string, WeatherInfo>();
        var line = Console.ReadLine();
        while (line != "end")
        {
            var weatherMatch = regex.Match(line);
            if (!weatherMatch.Success)
            {
                line = Console.ReadLine();
                continue;
            }

            var city = weatherMatch.Groups["city"].Value;
            var averageTemp = double.Parse(weatherMatch.Groups["temp"].Value);
            var weather = weatherMatch.Groups["weather"].Value;

            var weatherInfo = new WeatherInfo
            {
                AverageTemperature = averageTemp,
                Weather = weather
            };
            cities[city] = weatherInfo;
            line = Console.ReadLine();
        }
        var sortedCities = cities
            .OrderBy(a => a.Value.AverageTemperature)
            .ToDictionary(a => a.Key, a => a.Value);
        
    foreach (var cityInfo in sortedCities)
	{
            var city = cityInfo.Key;
            var weatherInfo = cityInfo.Value;
            Console.WriteLine($"{city} => {weatherInfo.AverageTemperature:f2} => {weatherInfo.Weather}");
	}
        



    }
}
class WeatherInfo
{
    public double AverageTemperature { get; set; }
    public string Weather { get; set; }
}
