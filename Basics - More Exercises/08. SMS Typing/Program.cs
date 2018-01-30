using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SMS_Typing
{
    class Program
    {
        static void Main(string[] args)
        {
            int countCharacters = int.Parse(Console.ReadLine());
            int[] array = new int[26];
            string result = string.Empty;
            for (int i = 0; i < countCharacters; i++)
            {
                int textMessage = int.Parse(Console.ReadLine());
                if (textMessage == 0)
                {
                    result += " ";
                }
                else
                {
                    int len = textMessage.ToString().Length;
                    int mainDigit = textMessage % 10;
                    int startIndex = (mainDigit - 2) * 3;

                    if (mainDigit == 8 || mainDigit == 9)
                    {
                        startIndex++;
                    }

                    int letterIndex = startIndex + len - 1;
                    result += (char)(97 + letterIndex);
                }
            }
            Console.WriteLine(result);
        }
    }
}
