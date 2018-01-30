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
        var currentHealth = int.Parse(Console.ReadLine());
        var maxHealth = int.Parse(Console.ReadLine());
        var currentEnergy = int.Parse(Console.ReadLine());
        var maxEnergy = int.Parse(Console.ReadLine());


        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("Health: |{0}{1}|",
            new string('|', currentHealth),
            new string('.', maxHealth - currentHealth));
        Console.WriteLine("Energy: |{0}{1}|",
            new string('|', currentEnergy),
            new string('.', maxEnergy - currentEnergy));
    }
}
