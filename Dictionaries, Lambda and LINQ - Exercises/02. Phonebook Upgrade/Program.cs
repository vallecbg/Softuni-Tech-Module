using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new SortedDictionary<string, string>();
            while (true)
            {
                string[] user = Console.ReadLine().Split();
                if (user[0] == "END")
                {
                    return;
                }
                if (user[0] == "A")
                {
                    phoneBook[user[1]] = user[2];
                }
                else if (user[0] == "S")
                {
                    if (phoneBook.ContainsKey(user[1]))
                    {
                        Console.WriteLine("{0} -> {1}", user[1], phoneBook[user[1]]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", user[1]);
                    }
                }
                else if (user[0] == "ListAll")
                {
                    foreach (var item in phoneBook)
                    {
                        Console.WriteLine("{0} -> {1}", item.Key, item.Value);
                    }
                }
            }
        }
    }
}
