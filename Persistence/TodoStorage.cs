using UtilitySuite.Core;

namespace UtilitySuite.Persistence
{
    /// <summary>
    /// Provides static methods for loading and saving to-do items to persistent storage.
    /// </summary>
    /// <remarks>This class manages the serialization and deserialization of to-do items to a text file in a
    /// designated data directory. Intended for single-user usage. Concurrent access may result in data loss. The class cannot be
    /// instantiated.</remarks>
    public static class TodoStorage
    {
        private const string DataFolder = "data";
        private const string FileName = "todos.txt";

        private static string FilePath => Path.Combine(DataFolder, FileName);

        /// <summary>
        /// Loads all to-do items from persistent storage.
        /// </summary>
        /// <remarks>If the data file does not exist, the method creates the data directory and returns an
        /// empty list. Malformed lines in the data file are ignored.</remarks>
        /// <returns>A list of <see cref="TodoItem"/> objects representing the loaded to-do items. Returns an empty list if
        /// no to-do items are found.</returns>
        public static List<TodoItem> LoadTodos()
        {
            Directory.CreateDirectory(DataFolder);

            if (!File.Exists(FilePath))
            {
                return new List<TodoItem>();
            }
            
            var lines = File.ReadAllLines(FilePath);

            var todos = new List<TodoItem>();

            foreach (var line in lines)
            {
                var parts = line.Split('|');

                if (parts.Length != 2)
                {
                    continue;
                }

                bool isDone = parts[0] == "1";
                string text = parts[1];

                todos.Add(new TodoItem
                {
                    Text = text,
                    IsDone = isDone
                });
            }

            return todos;
        }

        /// <summary>
        /// Saves the specified list of to-do items to persistent storage, overwriting any existing data.
        /// </summary>
        /// <remarks>Each to-do item is saved in a text file, with one item per line. Existing data in the
        /// file will be replaced.</remarks>
        /// <param name="todos">The list of to-do items to save. Cannot be null.</param>
        public static void SaveTodos(List<TodoItem> todos)
        {
            ArgumentNullException.ThrowIfNull(todos);

            Directory.CreateDirectory(DataFolder);

            var lines = todos.Select(todo =>
            {
                string doneFlag = todo.IsDone ? "1" : "0";
                return $"{doneFlag}|{todo.Text}";
            });

            File.WriteAllLines(FilePath, lines);
        }
    }
}
