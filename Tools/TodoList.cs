using System;
using UtilitySuite.Core;

namespace UtilitySuite.Tools
{
    public static class TodoList
    {

        public static ToolResult Run()
        {
            Console.WriteLine("To-do list coming soon...");
            Console.ReadKey();
            return ToolResult.Menu;
        }

    }
}
