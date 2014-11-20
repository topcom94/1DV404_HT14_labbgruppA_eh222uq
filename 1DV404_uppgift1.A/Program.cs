using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV404_uppgift1.A
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = "";
            int countLower = 0;
            int countUpper = 0;
            string[] inputTextArray = new string[inputText.Length];

            Console.Write("Mata in en textrad: ");
            inputText = Console.ReadLine();
            inputTextArray = inputText.Split(' ');

            foreach (char letter in inputText)
            {
                string charSign = letter.ToString();
                if (charSign == "a")
                {
                    countLower++;
                }
                else if (charSign == "A")
                {
                    countUpper++;
                }
                else
                {
                    
                }
            }
            Console.WriteLine("Antalet A är : " + countUpper);
            Console.WriteLine("Antalet a är : " + countLower);

        }
    }
}
