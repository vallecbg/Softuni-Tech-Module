using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersToRead = int.Parse(Console.ReadLine());
            var sum = 0;
            var numberInt = 0;
            var checker = false;
            for (int num = 1; num <= numbersToRead; num++)
            {
                numberInt = num;
                while (num > 0)
                {
                    sum += num % 10;
                    num = num / 10;
                }
                checker = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", numberInt, checker);
                sum = 0;
                num = numberInt;
            }
        }
    }
}
