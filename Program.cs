using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld 
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            int number;

            while (true)
            {
                Console.Write("Enter your first name: ");
                // set variable as type nullable string. if user enters empty
                // string, turn var into null

                string? nameInput = Console.ReadLine();

                // any tabs, spaces, whitespace will be rejected. 
                if (string.IsNullOrWhiteSpace(nameInput) == true)
                {
                    Console.WriteLine("Please don't enter whitespace.");
                    continue;
                }
                // letters (a-z) only accepted, De-guzman or De guzman are not accepted
                if (nameInput.All(Char.IsLetter) == false)
                {
                    Console.WriteLine("Names can only contain letters from the alphabet.");
                    continue;
                }

                nameInput = ToTitleCase(nameInput);

                Console.Write($"Your first name is {nameInput} correct? (y/n): ");
                string? answer = Console.ReadLine();

                if (answer == "y")
                {
                    break;
                }
                else if (answer == "n") 
                {
                    continue;
                }
                else 
                {
                    // TODO: BUG - when an incorrect 
                    Console.WriteLine("Please enter y or n");
                    continue;
                }
            }

            for(number=1; number<=10; number++)
            {
                Console.WriteLine($"Hello : {number}");
            }
        }

        static string ToTitleCase(string input)
        {
            var firstword = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.Split(' ')[0].ToLower());
            input = input.Replace(input.Split(' ')[0],firstword);
            return input;
        }
    }
}