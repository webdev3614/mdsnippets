// File: snippets/database-connection.cs
public class DatabaseConnection
{
    private string connectionString = "your_connection_string_here";

    public void Connect()
    {
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            Console.WriteLine("Database connected!");
        }
    }
}