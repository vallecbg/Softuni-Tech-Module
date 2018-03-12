using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var n = char.Parse(Console.ReadLine());
                if (n == 'a' || n == 'e' || n == 'o' || n == 'u' || n == 'i')
                {
                    Console.WriteLine("vowel");
                }
                else if (char.IsNumber(n))
                {
                    Console.WriteLine("digit");
                }
                else
                {
                    Console.WriteLine("other");
                }
            }
            catch (Exception)
            {
                Console.Write("Wrong digit, please enter again!");
            }
        }
    }
}
