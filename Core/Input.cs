using System;
using System.Collections.Generic;
using System.Text;

namespace UtilitySuite.Core
{
    public static class Input
    {
        public static int GetInt(string prompt, int min)
        {
            int inputVal;
            Console.Write(prompt);
            string intInput = Console.ReadLine();
            intInput = intInput.Trim();
            while (!Int32.TryParse(intInput, out inputVal) || inputVal < min)
            {
                Console.Write($"Invalid input. {prompt}");
                intInput = Console.ReadLine();
                intInput = intInput.Trim();
            }
            return inputVal;
        }

        public static int GetInt(string prompt, int min, int max)
        {
            int inputVal;
            Console.Write(prompt);
            string intInput = Console.ReadLine();
            intInput = intInput.Trim();
            while (!Int32.TryParse(intInput, out inputVal) || inputVal < min || inputVal > max)
            {
                Console.Write($"Invalid input. {prompt}");
                intInput = Console.ReadLine();
                intInput = intInput.Trim();
            }
            return inputVal;
        }

        public static int GetDecimal(string prompt, decimal min)
        {
            
        }

        public static int GetNonEmptyString(string prompt, string userInput)
        {
            
        }
    }
}
