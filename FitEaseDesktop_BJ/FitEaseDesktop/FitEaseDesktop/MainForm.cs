using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitEaseDesktop
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
            CreateDatabase();
            LoadExercises();
        }

        private void CreateDatabase()
        {
            string dbPath = "FitEase.db"; // Path to your SQLite database file    

            string connectionString = $"Data Source={dbPath};Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                // Create the 'exercises' table if it doesn't exist
                string createTableQuery = @"CREATE TABLE IF NOT EXISTS exercises (
                                                id INTEGER PRIMARY KEY AUTOINCREMENT, 
                                                name TEXT NOT NULL
                                            );";

                using (SQLiteCommand cmd = new SQLiteCommand(createTableQuery, conn))
                {
                    cmd.ExecuteNonQuery(); // Execute the command
                }
            }
        }
        private void LoadWorkout(string day)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT exercises FROM workouts WHERE day=@day";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@day", day);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblWorkout.Text = reader["exercises"].ToString();
                        }
                        else
                        {
                            lblWorkout.Text = "No workout found for " + day;
                        }
                    }
                }
            }
        }

        private void LoadMealPlan(string day)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT breakfast, lunch, dinner FROM meals WHERE day=@day";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@day", day);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblBreakfast.Text = reader["breakfast"].ToString();
                            lblLunch.Text = reader["lunch"].ToString();
                            lblDinner.Text = reader["dinner"].ToString();
                        }
                        else
                        {
                            lblBreakfast.Text = "No data";
                            lblLunch.Text = "No data";
                            lblDinner.Text = "No data";
                        }
                    }
                }
            }
        }
        private void btnMealPlan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Meal Plan Button Clicked!"); // Placeholder action
        }

        private void btnLoadMonday_Click(object sender, EventArgs e)
        {
            LoadWorkout("Monday");
            LoadMealPlan("Monday");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Some code
        }


        private void btnLoadTuesday_Click(object sender, EventArgs e)
        {
            LoadWorkout("Tuesday");
            LoadMealPlan("Tuesday");
        }

        private void btnLoadWednesday_Click(object sender, EventArgs e)
        {
            LoadWorkout("Wednesday");
            LoadMealPlan("Wednesday");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

        private void btnAddExercise_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtExercise.Text))
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO exercises (name) VALUES (@name)";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtExercise.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadExercises();
                txtExercise.Clear();
            }
        }


        private void LoadExercises()
        {
            lstExercises.Items.Clear();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT name FROM exercises";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lstExercises.Items.Add(reader["name"].ToString());
                    }
                }
            }
        }

        private void btnDeleteExercise_Click(object sender, EventArgs e)
        {
            if (lstExercises.SelectedItem != null)
            {
                string selectedExercise = lstExercises.SelectedItem.ToString();
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM exercises WHERE name=@name";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", selectedExercise);
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadExercises();
            }

        }

        private void btnUpdateExercise_Click(object sender, EventArgs e)
        {
            if (lstExercises.SelectedItem != null && !string.IsNullOrWhiteSpace(txtExercise.Text))
            {
                string oldExercise = lstExercises.SelectedItem.ToString();
                string newExercise = txtExercise.Text;

                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE exercises SET name=@newName WHERE name=@oldName";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@newName", newExercise);
                        cmd.Parameters.AddWithValue("@oldName", oldExercise);
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadExercises();
                txtExercise.Clear();
            }
        }
    }
}