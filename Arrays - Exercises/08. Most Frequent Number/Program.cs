using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var frequentNumber = new Dictionary<int, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (frequentNumber.ContainsKey(input[i]))
                {
                    frequentNumber[input[i]]++;
                }
                else
                {
                    frequentNumber[input[i]] = 1;
                }
            }
            var sorted = frequentNumber
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in sorted)
            {
                var outputKey = item.Key;
                Console.WriteLine(outputKey);
                return;
            }
        }
    }
}
