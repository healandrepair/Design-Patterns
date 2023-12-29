namespace Singleton;

// Singleton, define class with an instance of itself that is static and private.
public class Database
{
    // Make field private so it cant be accessed from outside the class.
    // Make field static ensures that is only 1 instance of this singleton and this is shared across all the Singleton classes
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