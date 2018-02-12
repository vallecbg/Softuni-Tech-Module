using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select
               (int.Parse).ToList();
            var start = 0;
            var beststart = 0;
            var length = 0;
            var bestlength = 0;

            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[start] == nums[i])
                {
                    length++;
                    if (length > bestlength)
                    {
                        bestlength = length;
                        beststart = start;
                    }
                }
                else
                {
                    start++;
                    i = start;
                    length = 0;
                }
            }
            for (int i = 0; i <= bestlength; i++)
            {
                Console.Write("{0} ", nums[beststart + i]);
            }
            Console.WriteLine();
        }
    }
}
