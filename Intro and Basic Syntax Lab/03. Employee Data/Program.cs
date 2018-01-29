using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var name = Console.ReadLine();
        var age = int.Parse(Console.ReadLine());
        var id = int.Parse(Console.ReadLine());
        var salary = double.Parse(Console.ReadLine());

        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Employee ID: {0}", id.ToString("D8"));
        Console.WriteLine("Salary: {0:F2}", salary);
    }
}
