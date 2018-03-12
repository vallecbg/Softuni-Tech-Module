using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());
            var price = 0.00;

            switch (profession)
            {
                case "Athlete":
                    price = 0.7 * quantity;
                    break;
                case "Businessman":
                    price = 1 * quantity;
                    break;
                case "Businesswoman":
                    price = 1 * quantity;
                    break;
                case "SoftUni Student":
                    price = 1.7 * quantity;
                    break;
                default:
                    price = 1.20 * quantity;
                    break;
            }
            Console.WriteLine("The {0} has to pay {1:F2}.", profession, price);
        }
    }
}
