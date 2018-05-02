using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var regex = @"(\+359 2 [0-9]{3} [0-9]{4}\b)|(\+359-2-[0-9]{3}-[0-9]{4}\b)";
            MatchCollection matchedNumbers = Regex.Matches(input, regex);
            var matchNum = new List<string>();
            foreach (Match number in matchedNumbers)
            {
                matchNum.Add(number.Value);
            }
            Console.WriteLine(string.Join(", ", matchNum));
        }
    }
}
