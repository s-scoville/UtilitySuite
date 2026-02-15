using System;
using UtilitySuite.Core;
using UtilitySuite.Persistence;

namespace UtilitySuite.Tools
{
    public static class TodoList
    {

        public static ToolResult Run()
        {
            var todos = TodoStorage.LoadTodos();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the To-Do List!");
                Console.WriteLine();
                Console.WriteLine("This tool allows you to keep a persistent to-do list, with options to add, remove, mark complete, and clear.");
                Console.WriteLine();

                if (todos.Count == 0)
                {
                    Console.WriteLine("No to-do items listed yet. Add one!");
                    Console.WriteLine();
                }
                else
                {
                    for (int i = 0; i < todos.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. [{(todos[i].IsDone ? "X" : " ")}] {todos[i].Text}");
                    }
                    Console.WriteLine();
                }
                int menuSelection = Input.GetInt("1. Add item\n2. Remove item\n3. Toggle complete/incomplete\n4. Clear to-do list\n5. Return to main menu\n6. Exit the utility suite\n\nPlease make a selection: ", 1, 6);

                switch (menuSelection)
                {
                    case 1:
                        {
                            todos.Add(new TodoItem { Text = Input.GetNonEmptyString("What would you like to add? "), IsDone = false });
                            TodoStorage.SaveTodos(todos);
                        }
                        continue;
                    case 2:
                        {
                            if (todos.Count != 0)
                            {
                                int removeIndex = Input.GetInt("Which item would you like to remove? ", 1, todos.Count) - 1;
                                todos.RemoveAt(removeIndex);
                                TodoStorage.SaveTodos(todos);
                            }
                            else
                            {
                                Console.WriteLine("No items exist in the to-do list.");
                                Console.WriteLine("Press enter to continue...");
                                Console.ReadLine();
                            }
                        }
                        continue;
                    case 3:
                        {
                            if (todos.Count != 0)
                            {
                                int changeIndex = Input.GetInt("Which item would you like to toggle? ", 1, todos.Count) - 1;
                                todos[changeIndex].IsDone = !todos[changeIndex].IsDone;
                                TodoStorage.SaveTodos(todos);
                            }
                            else
                            {
                                Console.WriteLine("No items exist in the to-do list.");
                                Console.WriteLine("Press enter to continue...");
                                Console.ReadLine();
                            }
                        }
                        continue;
                    case 4:
                        {
                            if (todos.Count != 0)
                            {
                                todos.Clear();
                                TodoStorage.SaveTodos(todos);
                            }
                            else
                            {
                                Console.WriteLine("No items exist in the to-do list.");
                                Console.WriteLine("Press enter to continue...");
                                Console.ReadLine();
                            }
                        }
                        continue;
                    case 5:
                        return ToolResult.Menu;
                    case 6:
                        return ToolResult.Exit;
                }
            }
        }

    }
}
