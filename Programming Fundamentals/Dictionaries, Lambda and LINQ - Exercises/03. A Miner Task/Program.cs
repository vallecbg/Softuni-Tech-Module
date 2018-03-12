using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>();
            while (true)
            {
                var resource = Console.ReadLine();
                if (resource == "stop") break;
                var quantity = int.Parse(Console.ReadLine());
                if (dict.ContainsKey(resource))
                {
                    dict[resource] += quantity;
                }
                else
                {
                    dict.Add(resource, quantity);
                }
            }
            foreach (var p in dict)
            {
                Console.WriteLine($"{p.Key} -> {p.Value}");
            }
        }
    }
}
