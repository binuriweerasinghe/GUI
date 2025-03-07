using System;
using System.Data.SQLite;

public class DatabaseHelper
{
    private static string connectionString = "Data Source=fitease.db;Version=3;";

    public static SQLiteConnection GetConnection()
    {
        return new SQLiteConnection(connectionString);
    }

    public static void InitializeDatabase()
    {
        using (var connection = GetConnection())
        {
            connection.Open();
            string createTablesQuery = @"
                CREATE TABLE IF NOT EXISTS users (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    username TEXT UNIQUE NOT NULL,
                    password TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS workouts (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    day TEXT NOT NULL,
                    exercises TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS meals (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    day TEXT NOT NULL,
                    breakfast TEXT,
                    lunch TEXT,
                    dinner TEXT
                );
            ";

            using (var command = new SQLiteCommand(createTablesQuery, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }
    public static void Connect()
    {
        using (var conn = new SQLiteConnection(connectionString))
        {
            try
            {
                conn.Open();
                Console.WriteLine("Connected to SQLite database successfully!");

                // Check if the table exists
                string query = "SELECT name FROM sqlite_master WHERE type='table' AND name='workouts'";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        Console.WriteLine("Table 'workouts' exists.");
                    }
                    else
                    {
                        Console.WriteLine("Table 'workouts' does not exist!");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
    public static void InsertSampleData()
    {
        using (var connection = GetConnection())
        {
            connection.Open();

            string insertWorkouts = @"
                INSERT INTO workouts (day, exercises) VALUES 
                ('Monday', 'Push-ups, Squats, Jump Rope, Plank'),
                ('Tuesday', 'Bench Press, Deadlifts, Lunges, Leg Press')
            ";

            string insertMeals = @"
                INSERT INTO meals (day, breakfast, lunch, dinner) VALUES 
                ('Monday', 'Oatmeal with fruit', 'Chicken rice', 'Grilled salmon with vegetables'),
                ('Tuesday', 'Scrambled eggs and toast', 'Pasta with tomato sauce', 'Grilled chicken with quinoa')
            ";

            using (var command = new SQLiteCommand(insertWorkouts, connection))
            {
                command.ExecuteNonQuery();
            }

            using (var command = new SQLiteCommand(insertMeals, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}
