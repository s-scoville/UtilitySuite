using System;
using UtilitySuite.Core;

namespace UtilitySuite.Tools
{
    public static class WordCounter
    {
        /// <summary>
        /// Runs the interactive word counter tool, allowing the user to input text and view character and word counts.
        /// </summary>
        /// <remarks>The method repeatedly prompts the user for input until the user chooses to return to
        /// the main menu or exit. The word count is determined by splitting the input text using common punctuation and
        /// whitespace delimiters.</remarks>
        /// <returns>A <see cref="ToolResult"/> value indicating the user's chosen action: <see cref="ToolResult.Menu"/> to
        /// return to the main menu, or <see cref="ToolResult.Exit"/> to exit the utility suite.</returns>
        public static ToolResult Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Word Counter!");
                Console.WriteLine();
                Console.WriteLine("This tool can be used to count the number of characters (including spaces) and words in any given string.");
                Console.WriteLine();

                Console.Write("Please enter your text: ");
                string input = Console.ReadLine() ?? string.Empty;

                char[] delimiters = new char[] {' ', ',', '.', '!', '?', '-'};
                string[] words = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                Console.WriteLine();
                Console.WriteLine($"The number of characters in the string is {input.Length}.");
                Console.WriteLine($"The number of words in the string is {words.Length}.");

                Console.WriteLine();

                int runAgain = Input.GetInt("1. Run word counter again\n2. Return to main menu\n3. Exit the utility suite\n\nPlease make a selection: ", 1, 3);

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
