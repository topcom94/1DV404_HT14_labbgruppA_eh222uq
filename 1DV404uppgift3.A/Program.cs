using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV404uppgift3.A
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";

            while (true)
            {
                try
                {
                    Console.WriteLine("Skrev en textrad :)");
                    userInput = Console.ReadLine().ToLower();
                    if (string.IsNullOrEmpty(userInput))
                    {
                        throw new FormatException();
                    }
                    break;
                }
                catch (Exception)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Du inte in någonting i raden!");
                    Console.ResetColor();
                }
            }
            bool isPalindrome = false;

            char[] charArray = userInput.ToCharArray();
            Array.Reverse(charArray);

            if (new string(charArray) == userInput)
            {
                isPalindrome = true;
            }

            if (isPalindrome)
            {
                Console.WriteLine("Texten är Palindrom!");
            }
            else
            {
                Console.WriteLine("Texten är inte Palidrom!");
            }

            Console.ReadKey();
        }
    }
}
