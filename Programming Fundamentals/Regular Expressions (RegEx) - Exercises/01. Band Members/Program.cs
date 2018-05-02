using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Band_Members
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pool = new Dictionary<string, Dictionary<string, long>>();

            while (input != "Season end")
            {
                var inputTokens = input.Split(new[] {" -> ", " vs "}, StringSplitOptions.RemoveEmptyEntries);

                if (inputTokens.Length == 3)
                {
                    var player = inputTokens[0];
                    var position = inputTokens[1];
                    var skill = long.Parse(inputTokens[2]);
                    if (!pool.ContainsKey(player))
                    {
                        pool.Add(player, new Dictionary<string, long>());
                    }


                    if (!pool[player].ContainsKey(position))
                    {
                        pool[player].Add(position, skill);
                    }
                    else
                    {
                        if (pool[player][position] < skill)
                        {
                            pool[player][position] = skill;
                        }
                    }

                    
                }
                else if (inputTokens.Length == 2)
                {
                    var player1 = inputTokens[0];
                    var player2 = inputTokens[1];
                    if (pool.ContainsKey(player1) && pool.ContainsKey(player2))
                    {
                        if (pool[player1].Values.Count > 0 &&
                            pool[player2].Values.Count > 0)
                        {
                            if (pool[player1].Keys.Count > 0 &&
                                pool[player2].Keys.Count > 0)
                            {
                                foreach (var p in pool[player1].Keys)
                                {
                                    if (pool[player2].ContainsKey(p))
                                    {
                                        if (pool[player1].Values.Sum() >
                                            pool[player2].Values.Sum())
                                        {
                                            pool.Remove(player2);
                                            break;
                                        }
                                        else if (pool[player1].Values.Sum() == pool[player2].Values.Sum())
                                        {
                                            break;
                                        }
                                        else if (pool[player1].Values.Sum() <
                                                 pool[player2].Values.Sum())
                                        {
                                            pool.Remove(player1);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                
                input = Console.ReadLine();
            }

            foreach (var player in pool.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                var name = player.Key;
                Console.WriteLine($"{name}: {pool[name].Values.Sum()} skill");
                foreach (var field in player.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {field.Key} <::> {field.Value}");
                }
            }
        }
    }
}