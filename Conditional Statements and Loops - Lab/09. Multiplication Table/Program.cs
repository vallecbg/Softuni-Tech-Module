using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {

                Console.WriteLine("{0} X {1} = {2}", number, i, (number * i));
            }
        }
    }
}
