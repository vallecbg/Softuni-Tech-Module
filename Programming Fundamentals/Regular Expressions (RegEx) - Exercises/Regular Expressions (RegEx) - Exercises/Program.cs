using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        var length = int.Parse(Console.ReadLine());
        var input = Console.ReadLine();
        var final = new int[length];
        var finalIndex = 0;
        var nums = new int[length];
        var index = 0;

        while (input != "Clone them!")
        {
            index++;

            nums = 
                input
                .Split(new[] {'!', ' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] parameters = GetInfo(nums);

            if (IsBetter(parameters, final))
            {
                final = nums;
                finalIndex = index;
            }

            if (finalIndex == 0)
            {
                final = nums;
                finalIndex = index;
            }

            input = Console.ReadLine();
        }

        Console.WriteLine($"Best DNA sample {finalIndex} with sum: {final.Sum()}.");
        Console.WriteLine(string.Join(" ", final));

    }

    private static bool IsBetter(int[] parameters, int[] final)
    {
        var finalParameters = GetInfo(final);
        if (parameters[0] > finalParameters[0])
        {
            return true;
        }
        else if (parameters[0] == finalParameters[0])
        {
            if (parameters[1] < finalParameters[1])
            {
                return true;
            }
            else if (parameters[1] == finalParameters[1])
            {
                if (parameters[2] > finalParameters[2])
                {
                    return true;
                }
            }
        }

        return false;
    }

    private static int[] GetInfo(int[] nums)
    {
        int sequence = 0;
        int position = 0;
        int sum = nums.Sum();
        int count = 0;
        int countMax = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                count++;
                // Best Sequence
                if (count > countMax)
                {
                    countMax = count;
                    position = i - count + 1;
                }
            }
            else
            {
                count = 0;
            }
        }

        sequence = countMax;

        return new int[] {sequence, position, sum};

    }
}