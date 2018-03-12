using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var emails = new Dictionary<string, string>();
            while (true)
            {
                var name = Console.ReadLine();
                if (name == "stop")
                {
                    foreach (var item in emails)
                    {
                        Console.WriteLine("{0} -> {1}", item.Key, item.Value);
                    }
                    return;
                }
                var email = Console.ReadLine();
                var emailCharacter = email.Split('@');
                if (emailCharacter[1].Contains(".uk"))
                {

                }
                else if (emailCharacter[1].Contains(".us"))
                {

                }
                else
                {
                    emails[name] = email;
                }

            }
        }
    }
}
