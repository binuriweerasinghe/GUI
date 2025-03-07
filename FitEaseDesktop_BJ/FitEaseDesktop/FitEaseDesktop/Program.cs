using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace FitEaseDesktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DatabaseHelper.InitializeDatabase();
            DatabaseHelper.InsertSampleData();

            CheckDatabaseConnection();
            DatabaseHelper.Connect();

            Application.Run(new LoginForm());
   
        }

        static void CheckDatabaseConnection()
        {
            string dbPath = @"D:\FitEaseDesktop\fitease.db";
            string connectionString = $"Data Source={dbPath};Version=3;";

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
    }
}
