using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int number = 2; number <= n; number++)
            {
                bool checkNumber = true;
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        checkNumber = false;
                        break;
                    }
                }
                Console.WriteLine($"{number} -> {checkNumber}");
            }
        }
    }
}
