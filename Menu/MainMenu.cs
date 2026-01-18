using System;
using UtilitySuite.Core;

namespace UtilitySuite.Menu
{
    public static class MainMenu
    {
        /// <summary>
        /// Runs the interactive utility suite, allowing the user to select and execute various tools from a menu-driven
        /// interface.
        /// </summary>
        /// <remarks>The method displays a menu with available utilities, including a tip calculator,
        /// temperature converter, word counter, and a simple to-do list. The method continues to prompt the user until
        /// the exit option is selected or a tool signals to exit. This method is called from the console
        /// application entry point.</remarks>
        public static void Run()
        {
            int userInput;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the utility suite!");
                Console.WriteLine();
                Console.WriteLine("1. Tip Calculator");
                Console.WriteLine("2. Temperature Converter");
                Console.WriteLine("3. Word Counter");
                Console.WriteLine("4. Simple To-Do List");
                Console.WriteLine("5. Exit Utility Suite");
                Console.WriteLine();
                
                userInput = Input.GetInt("Please make your selection (1-5): ", 1, 5);

                ToolResult result = ToolResult.Menu;

                switch(userInput)
                {
                    case 1:
                        result = TipCalculator.Run();
                        break;
                    case 2:
                        result = TemperatureConverter.Run();
                        break;
                    case 3:
                        result = WordCounter.Run();
                        break;
                    case 4:
                        result = TodoList.Run();
                        break;
                    case 5:
                        return;
                }

                if (result == ToolResult.Exit)
                {
                    return;
                }

            }
        }
    }
}
