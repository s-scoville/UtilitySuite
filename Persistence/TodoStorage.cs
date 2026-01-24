namespace UtilitySuite.Persistence
{
    /// <summary>
    /// Provides static methods for loading and saving to-do items as plain text files in a local data folder.
    /// </summary>
    /// <remarks>This class is intended for simple, single-user usage. Concurrent access from multiple processes or threads may result in data loss or corruption.
    /// The storage location is a subfolder named "data" in the application's working directory.</remarks>
    public static class TodoStorage
    {
        private const string DataFolder = "data";
        private const string FileName = "todos.txt";

        private static string FilePath => Path.Combine(DataFolder, FileName);

        /// <summary>
        /// Loads the list of to-do items from persistent storage.
        /// </summary>
        /// <returns>A list of strings containing all to-do items. Returns an empty list if no to-do items are found.</returns>
        public static List<string> LoadTodos()
        {
            Directory.CreateDirectory(DataFolder);

            if (!File.Exists(FilePath))
            {
                return new List<string>();
            }

            return File.ReadAllLines(FilePath).ToList();
        }

        /// <summary>
        /// Saves the specified list of to-do items to persistent storage.
        /// </summary>
        /// <param name="todos">The list of to-do items to save. Each item in the list represents a single to-do entry. Cannot be null.</param>
        public static void SaveTodos(List<string> todos)
        {
            ArgumentNullException.ThrowIfNull(todos);

            Directory.CreateDirectory(DataFolder);
            File.WriteAllLines(FilePath, todos);
        }
    }
}
