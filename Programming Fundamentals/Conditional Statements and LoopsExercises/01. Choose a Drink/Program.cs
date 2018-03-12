using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine().ToLower();

            switch (profession)
            {
                case "athlete":
                    Console.WriteLine("Water");
                    break;
                case "businessman":
                    Console.WriteLine("Coffee");
                    break;
                case "businesswoman":
                    Console.WriteLine("Coffee");
                    break;
                case "softuni student":
                    Console.WriteLine("Beer");
                    break;
                default:
                    Console.WriteLine("Tea");
                    break;
            }
        }
    }
}
