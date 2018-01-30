using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var firstLine = int.Parse(Console.ReadLine());
        var secondLine = int.Parse(Console.ReadLine());
        var thirdLine = int.Parse(Console.ReadLine());
        var fourthLine = int.Parse(Console.ReadLine());

        Console.WriteLine("{0} {1} {2} {3}", firstLine.ToString("D4"),
            secondLine.ToString("D4"),
            thirdLine.ToString("D4"),
            fourthLine.ToString("D4"));
    }
}
