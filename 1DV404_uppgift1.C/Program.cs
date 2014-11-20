using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV404_uppgift1.C
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfNumbers = 10;

            int nextHighest = 0;
            int highest = 0;
            int userInput;
            int i = 0;

            do 
            {
                try{

                    Console.Write("Tal {0}: ", i + 1);
                    userInput = int.Parse(Console.ReadLine());
                    if (i == 0)
                    {

                        highest = userInput;
                        nextHighest = userInput;

                    }
                    else if (userInput == highest && nextHighest == highest)
                    {
                        nextHighest = highest;
                        highest = userInput;
                    }
                    else
                    {
                        if (userInput > highest)
                        {
                            nextHighest = highest;
                            highest = userInput;
                        }
                        else if (userInput > nextHighest && userInput < highest || userInput < nextHighest &&nextHighest == highest)
                        {
                            nextHighest == userInput;
                        }
                     }
                    i++;
                }
                catch(Exception)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Skriv en giltig siffra!");
                    Console.ResetColor();

                }
            }while (i < amountOfNumbers);

            Console.BackgroundColor = ConsoleColor.Green;
            if (highest == nextHighest)
            {
                Console.WriteLine("Det finns ingen siffra som är högre än den högsta!");
            }
                else
                Console.WriteLine("näst störst: {0}", nextHighest);
                Console.ResetColor();
            }
        }
    }
}
