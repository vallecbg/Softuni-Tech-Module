using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());
        var area = a * b;

        Console.WriteLine("{0:F2}", area);
    }
}
