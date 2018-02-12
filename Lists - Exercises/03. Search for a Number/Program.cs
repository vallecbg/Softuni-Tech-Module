using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select
               (int.Parse).ToList();
            var commands = Console.ReadLine().Split(' ').ToList();

            var elementsToTake = int.Parse(commands[0]);
            var numbersToDelete = int.Parse(commands[1]);
            var searchedNumber = int.Parse(commands[2]);

            var tempNums = new int[elementsToTake];
            var count = 0;

            // Adding the new numbers to the list
            for (int i = 0; i < elementsToTake; i++)
            {
                tempNums[i] = nums[i];
            }

            var newNums = new List<int>(tempNums);

            // Removing the numbers from left to right
            for (int i = 0; i < numbersToDelete; i++)
            {
                newNums.RemoveAt(0);
            }

            for (int i = 0; i < newNums.Count; i++)
            {
                if (newNums[i] == searchedNumber)
                {
                    Console.WriteLine("YES!");
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
