using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var centuries = double.Parse(Console.ReadLine());
            var years = Math.Round(centuries * 100);
            var days = Math.Round(years * 365.2422);
            var hours = Math.Round(days * 24);
            var minutes = Math.Round(hours * 60);
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", centuries, years, days, hours, minutes);
        }
    }
}
