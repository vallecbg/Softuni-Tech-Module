using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            var peshodamage = int.Parse(Console.ReadLine());
            var goshodamage = int.Parse(Console.ReadLine());
            var peshoHealth = 100;
            var goshoHealth = 100;
            var peshoattacks = 0;
            var goshoattacks = 0;
            var rounds = 0;
            for (int i = 1; i <= int.MaxValue; i++)
            {
                rounds++;
                if (i % 2 == 1)
                {
                    peshoattacks++;
                    goshoHealth -= peshodamage;
                    if (goshoHealth <= 0)
                    {
                        Console.WriteLine("Pesho won in {0}th round.", rounds);
                        return;
                    }
                    Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", goshoHealth);
                }
                else if (i % 2 == 0)
                {
                    goshoattacks++;
                    peshoHealth -= goshodamage;
                    if (peshoHealth <= 0)
                    {
                        Console.WriteLine("Gosho won in {0}th round.", rounds);
                        return;
                    }
                    Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", peshoHealth);
                }
                if (i % 3 == 0)
                {
                    goshoHealth += 10;
                    peshoHealth += 10;
                }

            }
        }
    }
}
