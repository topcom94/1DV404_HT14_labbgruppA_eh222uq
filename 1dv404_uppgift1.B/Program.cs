using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv404_uppgift1.B
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;

            while (true)
            {
                try
                {
                    Console.Write("Mata in ett tal: ");
                    input = Console.ReadLine();
                    int.Parse(input);
                    break;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Talet är för stort, var vänlig och försök igen"); // använder mig av try catch för att se om talet är för stort eler inte kan tolkas.
                }
                catch
                {
                    Console.WriteLine("Talet som skrevs kan inte tolkas");
                }

            }

            int even = 0; 
            int odd = 0;
            int zeros = 0;  // ger int ett värde.
            

           for (int i = 0; i < input.Length; i++)
           {

               if (int.Parse(input[i].ToString()) == 0)
               {
                   zeros++;
               }
               else if (int.Parse(input[i].ToString()) % 2 == 0)
               {
                   even++;
               }
               else
               {
                   odd++;
               }

           }
           Console.WriteLine();
           Console.WriteLine("Nollor: {0} Udda: {1} Jämna: {2}", zeros, odd, even);

           }

        }
    }

