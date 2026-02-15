namespace UtilitySuite.Core
{
    public static class Input
    {
        /// <summary>
        /// Prompts the user to enter an integer value greater than or equal to the specified minimum.
        /// </summary>
        /// <remarks>The method repeatedly prompts the user until a valid integer greater than or equal to
        /// the specified minimum is entered. Input is read from the console and trimmed of leading and trailing
        /// whitespace.</remarks>
        /// <param name="prompt">The message displayed to the user when requesting input.</param>
        /// <param name="min">The minimum acceptable integer value. The user must enter a value greater than or equal to this value.</param>
        /// <returns>The integer value entered by the user that satisfies the minimum requirement.</returns>
        public static int GetInt(string prompt, int min)
        {
            int inputVal;
            Console.Write(prompt);
            string intInput = (Console.ReadLine() ?? string.Empty).Trim();

            while (!int.TryParse(intInput, out inputVal) || inputVal < min)
            {
                Console.Write($"Invalid input. {prompt}");
                intInput = (Console.ReadLine() ?? string.Empty).Trim();
            }
            return inputVal;
        }

        /// <summary>
        /// Prompts the user to enter an integer value within the specified range and returns the validated input.
        /// </summary>
        /// <remarks>The method repeatedly prompts the user until a valid integer within the specified
        /// range is entered. Input is read from the console and trimmed of leading and trailing whitespace.</remarks>
        /// <param name="prompt">The message displayed to the user when requesting input.</param>
        /// <param name="min">The minimum acceptable integer value, inclusive.</param>
        /// <param name="max">The maximum acceptable integer value, inclusive.</param>
        /// <returns>The integer value entered by the user that falls within the specified range.</returns>
        public static int GetInt(string prompt, int min, int max)
        {
            int inputVal;
            Console.Write(prompt);
            string intInput = (Console.ReadLine() ?? string.Empty).Trim();

            while (!int.TryParse(intInput, out inputVal) || inputVal < min || inputVal > max)
            {
                Console.Write($"Invalid input. {prompt}");
                intInput = (Console.ReadLine() ?? string.Empty).Trim();
            }
            return inputVal;
        }

        /// <summary>
        /// Prompts the user to enter a decimal value greater than or equal to the specified minimum, and returns the
        /// validated input.
        /// </summary>
        /// <remarks>The method repeatedly prompts the user until a valid decimal value that meets the
        /// minimum requirement is entered. Leading and trailing whitespace in the input is ignored.</remarks>
        /// <param name="prompt">The message displayed to the user when requesting input.</param>
        /// <param name="min">The minimum allowable value for the user's input. The entered value must be greater than or equal to this
        /// value.</param>
        /// <returns>A decimal value entered by the user that is greater than or equal to the specified minimum.</returns>
        public static decimal GetDecimal(string prompt, decimal min)
        {
            decimal decimalVal;
            Console.Write(prompt);
            string decimalInput = (Console.ReadLine() ?? string.Empty).Trim();

            while (!decimal.TryParse(decimalInput, out decimalVal) || decimalVal < min)
            {
                Console.Write($"Invalid input. {prompt}");
                decimalInput = (Console.ReadLine() ?? string.Empty).Trim();

            }
            return decimalVal;
        }

        /// <summary>
        /// Prompts the user to enter a decimal value and returns the parsed result after validating the input.
        /// </summary>
        /// <remarks>The method repeatedly prompts the user until a valid decimal value is entered.
        /// Leading and trailing whitespace in the input is ignored.</remarks>
        /// <param name="prompt">The message displayed to the user when requesting input. This should clearly indicate that a decimal value
        /// is expected.</param>
        /// <returns>The decimal value entered by the user after successful validation.</returns>
        public static decimal GetDecimal(string prompt)
        {
            decimal decimalVal;
            Console.Write(prompt);
            string decimalInput = (Console.ReadLine() ?? string.Empty).Trim();

            while (!decimal.TryParse(decimalInput, out decimalVal))
            {
                Console.Write($"Invalid input. {prompt}");
                decimalInput = (Console.ReadLine() ?? string.Empty).Trim();

            }
            return decimalVal;
        }

        /// <summary>
        /// Prompts the user for input and returns a non-empty string that does not contain the pipe (|) character.
        /// </summary>
        /// <remarks>If the user enters an empty string or a string containing the pipe (|) character, the
        /// method will repeatedly prompt until valid input is provided.</remarks>
        /// <param name="prompt">The message displayed to the user when requesting input.</param>
        /// <returns>A trimmed, non-empty string entered by the user that does not contain the pipe (|) character.</returns>
        public static string GetNonEmptyString(string prompt)
        {
            Console.Write(prompt);
            string input = (Console.ReadLine() ?? string.Empty).Trim();

            while (string.IsNullOrWhiteSpace(input) || input.Contains('|'))
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.Write($"Input cannot be empty. {prompt}");
                    input = (Console.ReadLine() ?? string.Empty).Trim();
                }
                else if(input.Contains('|'))
                {
                    Console.Write($"Input cannot contain the pipe (|) character. {prompt}");
                    input = (Console.ReadLine() ?? string.Empty).Trim();
                }
            }
            return input;
        }
    }
}
