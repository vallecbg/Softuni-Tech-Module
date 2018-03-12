using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArr =
               Console.ReadLine()
               .Split(new char[] { ' ' },
               StringSplitOptions.RemoveEmptyEntries);
            var secondArr =
                Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            var leftCount = FindMaxCommonItems(firstArr, secondArr);
            Array.Reverse(firstArr);
            Array.Reverse(secondArr);
            var rightCount = FindMaxCommonItems(firstArr, secondArr);

            Console.WriteLine($"{Math.Max(leftCount, rightCount)}");
        }

        static int FindMaxCommonItems(string[] firstArr, string[] secondArr)
        {
            int lenght = Math.Min(firstArr.Length, secondArr.Length);
            int count = 0;
            for (int i = 0; i < lenght; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            return count;
        }
    }
}
