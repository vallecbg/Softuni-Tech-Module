using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var mile = double.Parse(Console.ReadLine());
        var mileToKm = 1.60934;
        var km = mile * mileToKm;

        Console.WriteLine("{0:F2}", km);
    }
}