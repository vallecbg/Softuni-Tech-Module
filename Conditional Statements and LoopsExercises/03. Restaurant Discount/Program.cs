using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            var countOfPeople = int.Parse(Console.ReadLine());
            var hallType = Console.ReadLine().ToLower();
            var price = 0.00;

            if (countOfPeople <= 50)
            {
                price = 2500;
                Console.WriteLine("We can offer you the Small Hall");
            }
            else if (countOfPeople > 50 && countOfPeople <= 100)
            {
                price = 5000;
                Console.WriteLine("We can offer you the Terrace");
            }
            else if (countOfPeople > 100 && countOfPeople <= 120)
            {
                price = 7500;
                Console.WriteLine("We can offer you the Great Hall");
            }
            else if (countOfPeople > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            if (hallType == "normal")
            {
                price += 500;
                price -= price * 0.05;
            }
            else if (hallType == "gold")
            {
                price += 750;
                price -= price * 0.10;
            }
            else if (hallType == "platinum")
            {
                price += 1000;
                price -= price * 0.15;
            }

            var pricePerPerson = price / countOfPeople;
            Console.WriteLine("The price per person is {0:F2}$", pricePerPerson);

        }
    }
}
