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
    public partial class SignupForm: Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == txtConfirmPassword.Text)
            {
                MessageBox.Show("Registration successful!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Passwords do not match!");
            }

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO users (username, password) VALUES (@username, @password)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", txtNewUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtNewPassword.Text);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Account created successfully!");
                        this.Close();
                    }
                    catch (SQLiteException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
