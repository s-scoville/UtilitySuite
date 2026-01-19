using System;
using UtilitySuite.Core;


namespace UtilitySuite.Tools
{
    public static class TipCalculator
    {
        /// <summary>
        /// Runs the interactive tip calculator tool, allowing users to calculate and split meal costs including tip
        /// among multiple diners.
        /// </summary>
        /// <remarks>This method prompts the user for meal cost, tip percentage, and number of diners,
        /// then displays the total and per-diner cost. The user can choose to run the calculator again, return to the
        /// main menu, or exit the suite. The method operates in a console environment and requires user input for each
        /// calculation.</remarks>
        /// <returns>A ToolResult value indicating the user's chosen next action: Menu to return to the main menu, Exit to exit
        /// the utility suite.</returns>
        public static ToolResult Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Tip Calculator!");
                Console.WriteLine();
                Console.WriteLine("This tool calculates the split cost of the meal based on cost, tip percentage, and number of diners.");
                Console.WriteLine();

                decimal mealCost = Input.GetDecimal("Please enter the cost of the meal (XX.XX): ", 0);
                decimal tipAmount = Input.GetDecimal("Please enter the tip percentage: ", 0);
                int numDiners = Input.GetInt("Please enter the number of diners: ", 1);

                decimal totalCost = mealCost + (mealCost * (tipAmount / 100));
                decimal perDiner = totalCost / numDiners;

                Console.WriteLine();
                Console.WriteLine($"The total cost of the meal with tip is {totalCost:C2}.");
                Console.WriteLine($"With {numDiners} diner(s), the cost per diner is {perDiner:C2}.");

                Console.WriteLine();

                int runAgain = Input.GetInt("1. Run tip calculator again\n2. Return to main menu\n3. Exit the utility suite\n\nPlease make a selection: ", 1, 3);

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
