using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLetters = char.Parse(Console.ReadLine());
            var secondLetters = char.Parse(Console.ReadLine());
            var thirdLetters = char.Parse(Console.ReadLine());

            for (char i = firstLetters; i <= secondLetters; i++)
            {
                for (char j = firstLetters; j <= secondLetters; j++)
                {
                    for (char k = firstLetters; k <= secondLetters; k++)
                    {
                        if (i != thirdLetters && j != thirdLetters && k != thirdLetters)
                        {
                            Console.Write("{0}{1}{2} ", i, j, k);
                        }
                    }
                }
            }
        }
    }
}
