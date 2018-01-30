using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = Console.ReadLine().ToLower();
            var age = int.Parse(Console.ReadLine());
            var price = 0;

            if (0 <= age && age <= 18)
            {
                if (day == "weekday")
                {
                    price = 12;
                }
                if (day == "weekend")
                {
                    price = 15;
                }
                if (day == "holiday")
                {
                    price = 5;
                }
            }
            else if (18 < age && age <= 64)
            {
                if (day == "weekday")
                {
                    price = 18;
                }
                if (day == "weekend")
                {
                    price = 20;
                }
                if (day == "holiday")
                {
                    price = 12;
                }
            }
            else if (64 < age && age <= 122)
            {
                if (day == "weekday")
                {
                    price = 12;
                }
                if (day == "weekend")
                {
                    price = 15;
                }
                if (day == "holiday")
                {
                    price = 10;
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }
            if (price > 0)
            {
                Console.WriteLine("{0}$", price);

            }
        }
    }
}
