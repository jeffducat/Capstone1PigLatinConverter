using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone1PigLatinConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run;
            string vowels = "aeiou";
            string invalidCharacters = "1234567890!@#$%^&*()";

            Console.WriteLine("Welcome to the English to Pig Latin Converter!");

            run = true;

            while (run)
            {
                Console.WriteLine("Please enter a word to translate: ");

                string input = Console.ReadLine().ToLower();
                List<char> letters = input.ToList();
                Console.WriteLine("\nPig Latin Translation:");

                for (int i = 0; i < input.Length; i++)
                {
                    if (vowels.Contains(input.Substring(i, 1)))
                    {
                        string letter = i.Equals(0) ? "w" : "";                        

                        string prefix = input.Substring(0, i) + letter;
                        string suffix = input.Substring(i);

                        input = suffix + prefix + "ay";
                        break;
                    }
                    else if (invalidCharacters.Contains(input.Substring(i, 1)))
                    {
                        break;
                    }
                }

                Console.WriteLine(input);
                run = Methods.Continue("\nWould you like to translate another word? ( y / n)", "y", "n");
                Console.WriteLine();

            }

            Console.WriteLine("Thanks for using the Pig Latin Converter!  Goodbye!");
            Console.ReadLine();

        }
    }
}
