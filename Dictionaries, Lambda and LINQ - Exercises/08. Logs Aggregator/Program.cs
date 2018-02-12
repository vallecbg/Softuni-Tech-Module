using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var logs = new Dictionary<string, Dictionary<string, long>>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                var ip = input[0];
                var username = input[1];
                var duration = long.Parse(input[2]);
                if (!logs.ContainsKey(username))
                {
                    logs[username] = new Dictionary<string, long>();
                }
                if (!logs[username].ContainsKey(ip))
                {
                    logs[username][ip] = 0;
                }
                logs[username][ip] += duration;

            }
            foreach (var item in logs.OrderBy(x => x.Key))
            {
                var ipcount = new List<string>();
                var username = item.Key;
                var totalDuration = logs[username].Values.Sum();
                foreach (var ips in item.Value.OrderBy(x => x.Key))
                {
                    ipcount.Add(ips.Key);
                }
                Console.WriteLine($"{username}: {totalDuration} [{string.Join(", ", ipcount)}]");
            }
        }
    }
}
