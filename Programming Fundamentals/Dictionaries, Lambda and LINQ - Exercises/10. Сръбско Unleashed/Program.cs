using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _10.Сръбско_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string correctInputPattern = @"(([a-zA-Z]+\s){1,3})@(([a-zA-Z]+\s){1,3})(\d+)\s(\d+)";

                if (Regex.IsMatch(input, correctInputPattern))
                {
                    Match match = Regex.Match(input, correctInputPattern);

                    string singer = match.Groups[1].Value.Trim();
                    string venue = match.Groups[3].Value.Trim();
                    int ticketsPrice = int.Parse(match.Groups[5].Value);
                    int ticketsCount = int.Parse(match.Groups[6].Value);

                    int totalMoney = ticketsCount * ticketsPrice;

                    if (!dict.ContainsKey(venue))
                    {
                        dict.Add(venue, new Dictionary<string, int>() { { singer, totalMoney } });
                    }
                    else if (!dict[venue].ContainsKey(singer))
                    {
                        dict[venue].Add(singer, totalMoney);
                    }
                    else
                    {
                        dict[venue][singer] += totalMoney;
                    }
                }

            }

            foreach (var stage in dict)
            {
                Console.WriteLine(stage.Key);
                foreach (var artist in stage.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("#  {0} -> {1}", artist.Key, artist.Value);
                }
            }
        }
    }
}
