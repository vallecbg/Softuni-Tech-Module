using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            for (int i = 1; i <= int.MaxValue; i++)
            {
                var command = Console.ReadLine();


                if (command == "Bake!")
                {
                    Console.WriteLine("Preparing cake with {0} ingredients.", count);
                    return;
                }
                count++;

                Console.WriteLine("Adding ingredient {0}.", command);
            }

        }
    }
}
