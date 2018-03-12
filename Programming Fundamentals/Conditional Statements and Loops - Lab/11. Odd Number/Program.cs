using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < int.MaxValue; i++)
            {
                var number = Math.Abs(int.Parse(Console.ReadLine()));
                if (number % 2 == 1)
                {
                    Console.WriteLine("The number is: {0}", number);
                    return;
                }
                else
                {
                    Console.WriteLine("Please write an odd number.");
                }

            }
        }
    }
}
