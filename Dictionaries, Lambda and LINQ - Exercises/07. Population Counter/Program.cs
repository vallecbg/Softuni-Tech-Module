using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine();
            var countriesPopulation = new Dictionary<string, Dictionary<string, long>>();
            while (a != "report")
            {
                var data = a.Split('|').ToArray();
                var city = data[0];
                var country = data[1];
                var population = long.Parse(data[2]);
                if (!countriesPopulation.ContainsKey(country))
                {
                    countriesPopulation[country] = new Dictionary<string, long>();
                }
                if (!countriesPopulation[country].ContainsKey(city))
                {
                    countriesPopulation[country][city] = 0;
                }
                countriesPopulation[country][city] += population;

                a = Console.ReadLine();
            }
            foreach (var item in countriesPopulation.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                var country = item.Key;
                var totalPopulation = countriesPopulation[country].Values.Sum();
                Console.WriteLine($"{country} (total population: {totalPopulation})");
                foreach (var data in item.Value.OrderByDescending(x => x.Value))
                {
                    var city = data.Key;
                    var population = data.Value;
                    Console.WriteLine($"=>{city}: {population}");
                }
            }
        }
    }
}
