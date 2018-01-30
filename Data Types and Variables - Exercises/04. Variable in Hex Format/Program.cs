using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            var hex = Console.ReadLine();
            var value = Convert.ToInt32(hex, 16);
            Console.WriteLine("{0}", value);
        }
    }
}
