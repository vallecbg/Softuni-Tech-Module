using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.X
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var x = 'x';
            var space = ' ';

            // Upper triangle

            var middlespace = n - 2;
            var leftRightSpace = 0;

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}x{1}x{0}",
                    new string(space, i),
                    new string(space, middlespace));
                middlespace -= 2;
                leftRightSpace = i;
            }
            leftRightSpace++;

            // Middle string

            Console.WriteLine("{0}x{0}",
                new string(space, leftRightSpace));

            leftRightSpace--;
            middlespace = 1;

            // Lower triangle

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}x{1}x{0}",
                    new string(space, leftRightSpace),
                    new string(space, middlespace));
                middlespace += 2;
                leftRightSpace--;
            }
        }
    }
}
