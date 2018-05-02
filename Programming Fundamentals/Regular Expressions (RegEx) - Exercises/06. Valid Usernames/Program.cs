using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"\b[a-zA-Z][a-zA-Z0-9_]{2,24}\b";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            var sum = 0;
            var max = 0;
            var first = "";
            var second = "";

            for (int i = 1; i < matches.Count; i++)
            {
                sum = matches[i - 1].Length + matches[i].Length;
                if (sum > max)
                {
                    max = sum;
                    first = matches[i - 1].ToString();
                    second = matches[i].ToString();
                }
            }
            Console.WriteLine(first);
            Console.WriteLine(second);
        }
    }
}
