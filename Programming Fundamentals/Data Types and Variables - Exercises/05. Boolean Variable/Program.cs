using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            var boolean = Console.ReadLine();
            if (boolean == "True")
            {
                Console.WriteLine("Yes");
            }
            else if (boolean == "False")
            {
                Console.WriteLine("No");
            }
        }
    }
}
