namespace cocteleria_kris_backend.Repository;
using System.Data.SQLite;

public static class Repository
{
    // Public variable holding the connection
    public static SQLiteConnection? Connection { get; private set; }

    /// <summary>
    /// Initializes a new instance of the SQLiteDatabase class and opens a connection.
    /// </summary>
    /// <param name="databasePath">Path to the SQLite database file</param>
    public static void Initialize(string databasePath)
    {
        // Create connection string
        string connectionString = $"Data Source={databasePath};Version=3;";

        try
        {
            // Initialize the connection
            Connection = new SQLiteConnection(connectionString);

            // Open the connection
            Connection.Open();

            Console.WriteLine("SQLite connection established successfully.");
        }
        catch (SQLiteException ex)
        {
            Console.WriteLine($"Error connecting to SQLite database: {ex.Message}");
            throw;
        }
    }

    /// <summary>
    /// Closes the database connection
    /// </summary>
    public static void CloseConnection()
    {
        try
        {
            if (Connection != null && Connection.State != System.Data.ConnectionState.Closed)
            {
                Connection.Close();
                Console.WriteLine("SQLite connection closed.");
            }
        }
        catch (SQLiteException ex)
        {
            Console.WriteLine($"Error closing SQLite connection: {ex.Message}");
            throw;
        }
    }

    // Implement IDisposable to ensure proper cleanup
    public static void Dispose()
    {
        CloseConnection();
        Connection?.Dispose();
    }
}
