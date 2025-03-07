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
    public partial class LoginForm: Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "123")
            {
                MessageBox.Show("Admin Login Successful!");
                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.Show();
                return; // Exit the method to prevent database query
            }

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM users WHERE username=@username AND password=@password";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("Login Successful!");
                            MainForm mainForm = new MainForm();
                            this.Hide();
                            mainForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password!");
                        }
                    }
                }
            }
        }

        private void lnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            signupForm.Show();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}