using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = int.Parse(Console.ReadLine());
            var capacity = int.Parse(Console.ReadLine());

            if (persons > capacity)
            {
                var courses = (int)Math.Ceiling((double)persons / capacity);
                Console.WriteLine(courses);
            }
            if (persons <= capacity)
            {
                Console.WriteLine(1);
            }
        }
    }
}
