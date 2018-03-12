using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            while (true)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (input[0] == "print")
                {
                    break;
                }
                switch (input[0])
                {
                    case "add":
                        nums.Insert(int.Parse(input[1]), int.Parse(input[2]));
                        break;
                    case "addMany":
                        for (int i = input.Count - 1; i >= 2; i--)
                        {
                            nums.Insert(int.Parse(input[1]), int.Parse(input[i]));
                        }
                        break;
                    case "contains":
                        int contains = int.Parse(input[1]);
                        Console.WriteLine(nums.IndexOf(contains));
                        break;
                    case "remove":
                        nums.RemoveAt(int.Parse(input[1]));
                        break;
                    case "shift":
                        int positions = int.Parse(input[1]);
                        for (int i = 0; i < positions; i++)
                        {
                            int lastElement = nums[0];
                            for (int j = 0; j < nums.Count - 1; j++)
                            {
                                nums[j] = nums[j + 1];
                            }
                            nums[nums.Count - 1] = lastElement;
                        }
                        break;
                    case "sumPairs":
                        List<int> sumPairs = new List<int>();
                        for (int i = 0; i < nums.Count - 1; i += 2)
                        {
                            sumPairs.Add(nums[i] + nums[i + 1]);
                        }
                        if (nums.Count % 2 == 1)
                        {
                            sumPairs.Add(nums[nums.Count - 1]);
                        }
                        nums = sumPairs;
                        break;
                }
            }
            Console.WriteLine("[" + String.Join(", ", nums) + "]");
        }
    }
}
