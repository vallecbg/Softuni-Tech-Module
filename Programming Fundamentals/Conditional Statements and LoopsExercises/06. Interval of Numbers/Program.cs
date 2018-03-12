using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            if (a < b)
            {
                for (int i = a; i <= b; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else if (a > b)
            {
                for (int i = b; i <= a; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
