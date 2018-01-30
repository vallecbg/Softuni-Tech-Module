using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = Console.ReadLine();
            var lastName = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var gender = Console.ReadLine();
            var id = long.Parse(Console.ReadLine());
            var employeeNumber = long.Parse(Console.ReadLine());

            Console.WriteLine("First name: {0}", firstName);
            Console.WriteLine("Last name: {0}", lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID: {0}", id);
            Console.WriteLine("Unique Employee number: {0}", employeeNumber);
        }
    }
}
