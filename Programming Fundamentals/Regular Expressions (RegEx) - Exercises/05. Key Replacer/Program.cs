using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine();
            var text = Console.ReadLine();
            var keyPattern = @"([A-Za-z]+)([|<\\])(.+)([|<\\])([A-Za-z]+)";
            Regex keyRegex = new Regex(keyPattern);
            Match keymatch = keyRegex.Match(key);
            var message = new List<string>();
            if (keymatch.Success)
            {
                var start = keymatch.Groups[1].Value;
                var end = keymatch.Groups[5].Value;
                var wordPattern = start + @"(.{0,}?)" + end;
                Regex wordRegex = new Regex(wordPattern);
                Match wordMatch = wordRegex.Match(text);

                while (wordMatch.Success)
                {
                    if (wordMatch.Groups[1].Value == "")
                    {
                        text = text.Remove(wordMatch.Index, wordMatch.Length);
                    }
                    else
                    {
                        var word = wordMatch.Groups[1].Value;
                        message.Add(word);

                        text = text.Remove(wordMatch.Index, wordMatch.Length);
                    }

                    wordMatch = wordRegex.Match(text);

                }
            }

            if (message.Count == 0)
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(string.Join("", message));
            }
        }
    }
}
