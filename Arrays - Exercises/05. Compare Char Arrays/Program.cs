using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArray = Console.ReadLine().Split(' ').Select(s => char.Parse(s)).ToArray();
            var secondArray = Console.ReadLine().Split(' ').Select(s => char.Parse(s)).ToArray();
            int[] firstInt = new int[firstArray.Length];
            int[] secondInt = new int[secondArray.Length];
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstInt[i] = Convert.ToInt32(firstArray[i]);
            }
            for (int i = 0; i < secondArray.Length; i++)
            {
                secondInt[i] = Convert.ToInt32(secondArray[i]);
            }
            int sumFirst = firstInt.Sum();
            int sumSecond = secondInt.Sum();

            if (sumFirst == sumSecond)
            {
                Console.WriteLine(String.Join("", firstArray));
                Console.WriteLine(String.Join("", secondArray));
            }
            if (sumFirst < sumSecond)
            {
                Console.WriteLine(String.Join("", firstArray));
                Console.WriteLine(String.Join("", secondArray));
            }
            if (sumFirst > sumSecond)
            {
                Console.WriteLine(String.Join("", secondArray));
                Console.WriteLine(String.Join("", firstArray));
            }
        }
    }
}
