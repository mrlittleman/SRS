using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace SRS
{
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(courseCodeText.Text) || string.IsNullOrWhiteSpace(courseNameText.Text))
            {
                MessageBox.Show("Please enter course code and name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO courses (course_code, course_name, credit_hours, description) " +
                          "VALUES (@Code, @Name, @Credits, @Description)";

            try
            {
                using (MySqlConnection conn = new MySqlConnection("Server=localhost;Database=student_record_system;User=root;Password=;"))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Code", courseCodeText.Text.Trim());
                        cmd.Parameters.AddWithValue("@Name", courseNameText.Text.Trim());
                        cmd.Parameters.AddWithValue("@Credits", creditHoursNumeric.Value);
                        cmd.Parameters.AddWithValue("@Description", descriptionText.Text.Trim());

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Course added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding course: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}