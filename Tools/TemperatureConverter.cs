using System;
using UtilitySuite.Core;

namespace UtilitySuite.Tools
{
    public static class TemperatureConverter
    {
        /// <summary>
        /// Runs the interactive temperature converter tool, allowing the user to convert temperatures between Celsius
        /// and Fahrenheit.
        /// </summary>
        /// <remarks>The method displays prompts and reads input from the console. It continues to run
        /// until the user chooses to return to the main menu or exit. Input validation is performed for all user
        /// selections.</remarks>
        /// <returns>A value indicating the user's chosen action after using the converter: <see cref="ToolResult.Menu"/> to
        /// return to the main menu, or <see cref="ToolResult.Exit"/> to exit the utility suite.</returns>
        public static ToolResult Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Temperature Converter!");
                Console.WriteLine();
                Console.WriteLine("This tool converts Celsius to Fahrenheit or Fahrenheit to Celsius.");
                Console.WriteLine();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Convert Celsius to Fahrenheit");
                Console.WriteLine("2. Convert Fahrenheit to Celsius");
                Console.WriteLine();
                int convertDirection = Input.GetInt("Please make a selection (1-2): ", 1, 2);
                Console.WriteLine();

                switch (convertDirection)
                {
                    case 1:
                        {
                            Console.WriteLine("You chose to convert Celsius to Fahrenheit.");
                            decimal temperature = Input.GetDecimal("Please enter the temperature: ");
                            Console.WriteLine();
                            decimal convertedTemp = ((temperature * (9m / 5m)) + 32m);
                            Console.WriteLine($"{temperature:F1}° Celsius converts to {convertedTemp:F1}° Fahrenheit.");
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("You chose to convert Fahrenheit to Celsius.");
                            decimal temperature = Input.GetDecimal("Please enter the temperature: ");
                            Console.WriteLine();
                            decimal convertedTemp = (temperature - 32m) * (5m / 9m);
                            Console.WriteLine($"{temperature:F1}° Fahrenheit converts to {convertedTemp:F1}° Celsius.");
                        }
                        break;
                }

                Console.WriteLine();

                int runAgain = Input.GetInt("1. Run temperature converter again\n2. Return to main menu\n3. Exit the utility suite\n\nPlease make a selection: ", 1, 3);

                switch (runAgain)
                {
                    case 1:
                        continue;
                    case 2:
                        return ToolResult.Menu;
                    case 3:
                        return ToolResult.Exit;
                }
            }
        }
        
    }
}
