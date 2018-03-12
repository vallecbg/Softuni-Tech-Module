using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var stopCount = int.Parse(Console.ReadLine());
            var sum = 0;
            var combinations = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    combinations++;
                    sum += 3 * (i * j);
                    if (sum >= stopCount)
                    {
                        Console.WriteLine("{0} combinations", combinations);
                        Console.WriteLine("Sum: {0} >= {1}", sum, stopCount);
                        return;
                    }
                }
            }
            if (sum < stopCount)
            {
                Console.WriteLine("{0} combinations", combinations);
                Console.WriteLine("Sum: {0}", sum);
            }
        }
    }
}
