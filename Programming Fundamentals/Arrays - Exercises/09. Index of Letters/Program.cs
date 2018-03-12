using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().ToLower();
            var input = a.ToCharArray();
            for (int i = 0; i < input.Length; i++)
            {
                var letter = input[i];
                var index = char.ToUpper(input[i]) - 64 - 1;
                Console.WriteLine("{0} -> {1}", letter, index);
            }
        }
    }
}
