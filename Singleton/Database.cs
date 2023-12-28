namespace Singleton;

// Singleton, define class with an instance of itself that is static and private.
public class Database
{
    private static Database _database;

    // Private constructor so it cant be instantiated outside of getInstance method.
    private Database()
    {
        // Connections to server etc
    }

    public static Database GetInstance()
    {
        if (_database == null)
        {
            // Assign a new instance if there is no existing instance
            _database = new Database();
        }
        
        return _database;
    }

    public void Query(string query)
    {
        Console.WriteLine(query);
    }
}