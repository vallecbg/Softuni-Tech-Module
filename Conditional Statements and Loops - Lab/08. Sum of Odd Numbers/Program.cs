using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var count = 0;
            var max = int.MaxValue;
            for (int i = 1; i <= max; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                    sum += i;
                    count++;
                }
                if (count == n)
                {
                    break;
                }
            }
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
