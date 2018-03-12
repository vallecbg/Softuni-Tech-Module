using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = byte.Parse(Console.ReadLine());
            var multiplier = byte.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"{number} X {multiplier} = {number * multiplier}");
                multiplier++;
            }
            while (multiplier <= 10);
        }
    }
}
