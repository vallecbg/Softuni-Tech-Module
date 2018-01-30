using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var lastDigit = 0;
            var firstDigit = 0;

            for (int i = 1; i <= num; i++)
            {
                firstDigit = i % 10;
                lastDigit = i / 10;

                if (firstDigit + lastDigit == 5 ||
                    firstDigit + lastDigit == 7 ||
                    firstDigit + lastDigit == 11)
                {
                    Console.WriteLine("{0} -> True", i);
                }
                else
                {
                    Console.WriteLine("{0} -> False", i);
                }
            }
        }
    }
}
