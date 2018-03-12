using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var logs = new SortedDictionary<string, Dictionary<string, int>>();
            var ip = "";
            var message = "";
            var user = "";
            while (input != "end")
            {
                var userLog = input.Split(new string[] { " ", "\'", "IP=", "message=", "user=" }, StringSplitOptions.RemoveEmptyEntries);
                if (userLog.Length == 2)
                {
                    ip = userLog[0];
                    message = "";
                    user = userLog[1];
                }
                else
                {
                    ip = userLog[0];
                    message = userLog[1];
                    user = userLog[2];
                }
                if (!logs.ContainsKey(user))
                {
                    logs.Add(user, new Dictionary<string, int>());
                    logs[user].Add(ip, 1);
                }
                else
                {
                    if (logs[user].ContainsKey(ip))
                    {
                        logs[user][ip] += 1;
                    }
                    else
                    {
                        logs[user].Add(ip, 1);
                    }
                }

                input = Console.ReadLine();
            }
            foreach (var item in logs)
            {
                Console.WriteLine("{0}:", item.Key);
                foreach (var values in item.Value)
                {
                    var last = item.Value.Keys.Last();
                    var value = values.Key.ToString();
                    if (last == value)
                    {
                        Console.Write("{0} => {1}.", values.Key, values.Value);
                    }
                    else
                    {
                        Console.Write("{0} => {1}, ", values.Key, values.Value);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
