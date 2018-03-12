using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int length = numbers.Length;

            MaxIncSequence(numbers, length);
        }

        static void MaxIncSequence(int[] numbers, int l)
        {
            var cntCurrSeq = 0;
            var startCurrSeq = 0;
            var cntMaxSeq = 0;
            var startMaxSeq = 0;

            for (int i = 1; i < l; i++)
            {
                if (numbers[i] - numbers[i - 1] >= 1)
                {
                    cntCurrSeq++;
                    startCurrSeq = i - cntCurrSeq;

                    if (cntCurrSeq > cntMaxSeq)
                    {
                        cntMaxSeq = cntCurrSeq;
                        startMaxSeq = startCurrSeq;
                    }
                }
                else
                {
                    cntCurrSeq = 0;
                }
            }
            for (int iWrite = startMaxSeq; iWrite <= (startMaxSeq + cntMaxSeq); iWrite++)
            {
                Console.Write(numbers[iWrite] + " ");
            }
            Console.WriteLine();
        }
    }
}
