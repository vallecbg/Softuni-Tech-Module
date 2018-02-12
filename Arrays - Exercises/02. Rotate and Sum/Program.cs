using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var myArray = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            var K = int.Parse(Console.ReadLine());

            myArray = CyclicRotation(myArray, K);
            Console.WriteLine(string.Join(" ", myArray));

        }
        public static int[] CyclicRotation(int[] myArray, int K)
        {
            if (myArray.Length <= 1)
            {
                return myArray;
            }

            int[] sumArray = new int[myArray.Length];

            for (int i = 0; i < K; i++)
            {
                int lastElement = myArray[myArray.Length - 1];
                int[] newArray = new int[myArray.Length];
                newArray[0] = lastElement;

                for (int j = 1; j < myArray.Length; j++)
                {

                    newArray[j] = myArray[j - 1];
                }
                for (int j = 0; j < sumArray.Length; j++)
                {
                    sumArray[j] += newArray[j];
                }

                myArray = newArray;
            }
            return sumArray;
        }
    }
}
