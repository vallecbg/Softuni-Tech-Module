using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            minutes += 30;

            if (minutes > 59)
            {
                hours++;
                minutes -= 60;
            }
            if (hours == 24)
            {
                hours = 0;
            }
            if (hours > 23)
            {
                hours++;
                minutes -= 60;
            }


            Console.WriteLine("{0}:{1}", hours, minutes.ToString("D2"));
        }
    }
}
