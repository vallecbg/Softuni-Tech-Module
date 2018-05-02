using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> result = Console.ReadLine().Split(' ', '-').ToList();

            string input = Console.ReadLine();

            while (input != "Play!")
            {
                var commands = input.Split().ToArray();
                string command = commands[0];
                string game = commands[1];

                if (command == "Install")
                {
                    if (!result.Contains(game))
                    {
                        result.Add(game);
                    }
                }
                if (command == "Uninstall")
                {
                    result.Remove(game);
                }
                if (command == "Update")
                {
                    if (result.Contains(game))
                    {
                        result.Remove(game);
                        result.Add(game);
                    }
                }
                if (command == "Expansion")
                {
                    var modif = game.Split('-').ToArray();
                    string gm = modif[0];
                    string ex = modif[1];
                    if (result.Contains(gm))
                    {
                        var expan = game;
                        expan = expan.Replace('-', ':');
                        var position = result.IndexOf(gm);
                        result.Insert(position + 1, expan);
                    }

                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
