using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            var cityTemperature = new Dictionary<string, double>();
            var cityWeather = new Dictionary<string, string>();
            var pattern = @"([A-Z]{2})(\d+\.\d+)([A-Za-z]+)\|";
            Regex regex = new Regex(pattern);
            var input = Console.ReadLine();
            Match match = regex.Match(input);
            while (input != "end")
            {
                match = regex.Match(input);
                if (match.Success)
                {


                    var cityName = match.Groups[1].Value;
                    var averageTemp = double.Parse(match.Groups[2].Value);
                    var typeWeather = match.Groups[3].Value;

                    cityTemperature[cityName] = averageTemp;
                    cityWeather[cityName] = typeWeather;
                }

                input = Console.ReadLine();
            }

            Dictionary<string, double> sortedCities =
                cityTemperature
                    .OrderBy(x => x.Value)
                    .ToDictionary(x => x.Key, x => x.Value);
            foreach (var sortedCity in sortedCities)
            {
                var cityName = sortedCity.Key;
                var averageTemp = sortedCity.Value;
                var typeOfWeather = cityWeather[cityName];
                Console.WriteLine($"{cityName} => {averageTemp:F2} => {typeOfWeather}");
            }
        }
    }
}
