using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var magicnumber = int.Parse(Console.ReadLine());
            var combinations = 0;
            var a = 0;
            var b = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    combinations++;
                    if (i + j == magicnumber)
                    {
                        Console.WriteLine("Number found! {0} + {1} = {2}", j, i, magicnumber);
                        return;
                    }
                    a = i;
                    b = j;
                }

            }
            if (a + b != magicnumber)
            {
                Console.WriteLine("{0} combinations - neither equals {1}", combinations, magicnumber);
            }
        }
    }
}
