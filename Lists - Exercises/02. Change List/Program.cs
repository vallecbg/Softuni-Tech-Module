using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select
            (int.Parse).ToList();

            var commands = Console.ReadLine().Split(' ').ToList();
            while (commands[0] != "Odd" && commands[0] != "Even")
            {
                if (commands[0] == "Delete")
                {
                    var delnumber = int.Parse(commands[1]);
                    nums.RemoveAll(i => i == delnumber);
                }
                else if (commands[0] == "Insert")
                {
                    var insertIndex = int.Parse(commands[1]);
                    var insertPosition = int.Parse(commands[2]);
                    nums.Insert(insertPosition, insertIndex);
                }
                commands = Console.ReadLine().Split(' ').ToList();
            }
            if (commands[0] == "Odd")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] % 2 == 1)
                    {
                        Console.Write("{0} ", nums[i]);
                    }
                }
            }
            else if (commands[0] == "Even")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] % 2 == 0)
                    {
                        Console.Write("{0} ", nums[i]);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
