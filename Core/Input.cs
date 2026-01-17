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
            while (!int.TryParse(intInput, out inputVal) || inputVal < min)
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
            while (!int.TryParse(intInput, out inputVal) || inputVal < min || inputVal > max)
            {
                Console.Write($"Invalid input. {prompt}");
                intInput = Console.ReadLine();
                intInput = intInput.Trim();
            }
            return inputVal;
        }

        //Validates decimal inputs for data type and min value, returns decimal if valid.
        public static decimal GetDecimal(string prompt, decimal min)
        {
            decimal decimalVal;
            Console.Write(prompt);
            string decimalInput = Console.ReadLine();
            decimalInput = decimalInput.Trim();
            while (!decimal.TryParse(decimalInput, out decimalVal) || decimalVal < min)
            {
                Console.Write($"Invalid input. {prompt}");
                decimalInput = Console.ReadLine();
                decimalInput = decimalInput.Trim();
            }
            return decimalVal;
        }

        //Validates decimal inputs for data type only, returns decimal if valid.
        public static decimal GetDecimal(string prompt)
        {
            decimal decimalVal;
            Console.Write(prompt);
            string decimalInput = Console.ReadLine();
            decimalInput = decimalInput.Trim();
            while (!decimal.TryParse(decimalInput, out decimalVal))
            {
                Console.Write($"Invalid input. {prompt}");
                decimalInput = Console.ReadLine();
                decimalInput = decimalInput.Trim();
            }
            return decimalVal;
        }

        public static string GetNonEmptyString(string prompt)
        {
            
        }
    }
}
