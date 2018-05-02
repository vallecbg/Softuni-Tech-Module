using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"(?<=\s|^)([a-z0-9]+[_.-]?[a-z0-9]*@[a-z]+\-?[a-z]+(?:\.[a-z]+)+)\b";
            var numbers = Regex.Matches(input, pattern);
            var numbersList = new List<string>();
            foreach (Match item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
