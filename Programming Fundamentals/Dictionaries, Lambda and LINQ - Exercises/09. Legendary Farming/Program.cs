using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyMaterial = new Dictionary<string, long>();
            keyMaterial["shards"] = 0;
            keyMaterial["fragments"] = 0;
            keyMaterial["motes"] = 0;
            var nonKeyMaterial = new Dictionary<string, long>();

            var winnerMaterial = "";
            var itemSearch = true;
            var winner = "";

            while (itemSearch)
            {
                var list = Console.ReadLine().Split().ToList();
                for (int i = 0; i < list.Count; i += 2)
                {
                    var quantity = long.Parse(list[i]);
                    var material = list[i + 1].ToLower();

                    if (keyMaterial.ContainsKey(material))
                    {
                        keyMaterial[material] += quantity;
                        if (keyMaterial[material] >= 250)
                        {
                            winnerMaterial = material;
                            keyMaterial[material] -= 250;
                            itemSearch = false;
                            break;
                        }
                    }
                    else
                    {
                        if (!nonKeyMaterial.ContainsKey(material))
                        {
                            nonKeyMaterial[material] = 0;
                        }
                        nonKeyMaterial[material] += quantity;
                    }
                }
            }
            switch (winnerMaterial)
            {
                case "shards": winner = "Shadowmourne"; break;
                case "fragments": winner = "Valanyr"; break;
                case "motes": winner = "Dragonwrath"; break;
            }
            keyMaterial = keyMaterial
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
            nonKeyMaterial = nonKeyMaterial
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine($"{winner} obtained!");
            foreach (var item in keyMaterial)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in nonKeyMaterial)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
