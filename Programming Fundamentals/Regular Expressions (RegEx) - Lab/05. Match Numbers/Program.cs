using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            var numbers = Regex.Matches(input, pattern);
            var numbersList = new List<string>();
            foreach (Match item in numbers)
            {
                numbersList.Add(item.Value);
            }
            Console.WriteLine(string.Join(" ", numbersList));
        }
    }
}
