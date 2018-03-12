using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dragonData = new Dictionary<string, Dictionary<string, int[]>>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var type = input[0];
                var name = input[1];
                var damage = 45;
                if (input[2] != "null")
                {
                    damage = int.Parse(input[2]);
                }
                var health = 250;
                if (input[3] != "null")
                {
                    health = int.Parse(input[3]);
                }
                var armor = 10;
                if (input[4] != "null")
                {
                    armor = int.Parse(input[4]);
                }

                if (!dragonData.ContainsKey(type))
                {
                    dragonData[type] = new Dictionary<string, int[]>() { { name, new int[] { damage, health, armor } } };
                }
                else
                {
                    if (dragonData[type].ContainsKey(name))
                    {
                        dragonData[type][name][0] = damage;
                        dragonData[type][name][1] = health;
                        dragonData[type][name][2] = armor;
                    }
                    else
                    {
                        dragonData[type].Add(name, new int[] { damage, health, armor });
                    }
                }
            }
            foreach (var item in dragonData)
            {
                var color = item.Key;
                double damageAverage = item.Value.Select(x => x.Value[0]).Average();
                double healthAverage = item.Value.Select(x => x.Value[1]).Average();
                double armorAverage = item.Value.Select(x => x.Value[2]).Average();
                Console.WriteLine($"{color}::({damageAverage:F2}/{healthAverage:F2}/{armorAverage:F2})");
                foreach (var value in item.Value.OrderBy(x => x.Key))
                {
                    var dragonName = value.Key;
                    var damage = value.Value[0];
                    var health = value.Value[1];
                    var armor = value.Value[2];
                    Console.WriteLine($"-{dragonName} -> damage: {damage}, health: {health}, armor: {armor}");
                }
            }
        }
    }
}
