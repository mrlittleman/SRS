using DotNetEnv;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using BCrypt.Net; // Make sure this is included in your project references

namespace SRS
{
    public partial class LoginView : Form
    {
        private string connectionString;

        public LoginView()
        {
            InitializeComponent();
            // Load the .env file (for production environment variables)
            //Env.Load();

            // Retrieve connection string from environment variables if necessary
            connectionString = "Server=localhost;Database=student_record_system;User=root;Password=;";
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UserField.Text.Trim();
            string password = PasswordField.Text.Trim();

            if (IsValidLogin(username, password))
            {
                StudentRecordSystemView studentRecord = new StudentRecordSystemView();
                studentRecord.Show();
                this.Hide();
            }
        }

        private bool IsValidLogin(string username, string password)
        {
            string query = "SELECT password FROM user WHERE username = @Username";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        string? storedHashedPassword = cmd.ExecuteScalar()?.ToString();

                        if (storedHashedPassword == null)
                        {
                            MessageBox.Show("User not found.");
                            return false;
                        }

                        bool isPasswordValid = BCrypt.Net.BCrypt.Verify(password, storedHashedPassword);

                        if (!isPasswordValid)
                        {
                            MessageBox.Show("Invalid password.");
                        }

                        return isPasswordValid;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
    }
}
