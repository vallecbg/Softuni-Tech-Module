using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            var k = numbers.Length / 4;

            var leftArray = numbers.Take(k).ToArray();
            var midArray = numbers.Skip(k).Take(k * 2).ToArray();
            var rightArray = numbers.Skip(k * 3).Take(k).ToArray();

            Array.Reverse(leftArray);
            Array.Reverse(rightArray);

            var mergeLeftRight = new int[leftArray.Length + rightArray.Length];
            leftArray.CopyTo(mergeLeftRight, 0);
            rightArray.CopyTo(mergeLeftRight, leftArray.Length);

            var result = new int[mergeLeftRight.Length];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = mergeLeftRight[i] + midArray[i];
            }
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
