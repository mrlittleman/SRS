using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRS
{
    public partial class StudentRecordSystemView : Form
    {
        public StudentRecordSystemView()
        {
            InitializeComponent();
            DisableFields();
            LoadStudentData();
            dataGridView1.ReadOnly = true;
            CancelBtn.Enabled = false;
        }

        private void LogoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                LoginView login = new LoginView();
                login.Show();
                this.Hide();
            }
        }
        private void DisableFields()
        {
            AddStudentNumberField.Enabled = false;
            NameField.Enabled = false;
            AgeField.Enabled = false;
            BirthDatePicker.Enabled = false;
            AddressField.Enabled = false;
        }
        private void EnableFields()
        {
            AddStudentNumberField.Enabled = true;
            NameField.Enabled = true;
            AgeField.Enabled = true;
            BirthDatePicker.Enabled = true;
            AddressField.Enabled = true;
        }
        private void ClearFields()
        {
            AddStudentNumberField.Clear();
            NameField.Clear();
            AgeField.Clear();
            AddressField.Clear();
            BirthDatePicker.Value = DateTime.Now;
        }

        private string? _currentGeneratedStudentNumber = null;
        private string GenerateStudentNumber()
        {
            Random random = new Random();
            int randomNumber = 0;
            bool isUnique = false;

            while (!isUnique)
            {
                randomNumber = random.Next(1000, 10000);
                string checkQuery = "SELECT COUNT(*) FROM student_information WHERE student_no = @StudentNumber";
                using (MySqlConnection conn = new MySqlConnection("Server=localhost;Database=student_record_system;User=root;Password=;"))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(checkQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentNumber", randomNumber);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count == 0)
                        {
                            isUnique = true;
                        }
                    }
                }
            }

            return randomNumber.ToString();
        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            EnableFields();
            AddStudentNumberField.Enabled = false;
            SearchBtn.Enabled = false;
            AddBtn.Text = "Save";
            AddBtn.Click -= AddBtn_Click;
            AddBtn.Click += SaveBtn_Click;
            CancelBtn.Enabled = true;

            if (string.IsNullOrEmpty(_currentGeneratedStudentNumber))
            {
                _currentGeneratedStudentNumber = GenerateStudentNumber();
            }

            AddStudentNumberField.Text = _currentGeneratedStudentNumber;
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            AddStudentNumberField.Enabled = false;
            SearchBtn.Enabled = true;
            string studentNumber = AddStudentNumberField.Text.Trim();
            string fullName = NameField.Text.Trim();
            int age = 0;
            DateTime birthDate = BirthDatePicker.Value;
            string address = AddressField.Text.Trim();

            if (string.IsNullOrEmpty(studentNumber) || string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(AgeField.Text, out age) || age <= 0)
            {
                MessageBox.Show("Please enter a valid age.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string checkQuery = "SELECT full_name FROM student_information WHERE student_no = @StudentNumber";
            string? existingFullName = null;

            string query = "INSERT INTO student_information (student_no, full_name, age, birth_date, address) " +
                           "VALUES (@StudentNumber, @FullName, @Age, @BirthDate, @Address)";

            try
            {
                using (MySqlConnection conn = new MySqlConnection("Server=localhost;Database=student_record_system;User=root;Password=;"))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(checkQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentNumber", studentNumber);

                        existingFullName = cmd.ExecuteScalar()?.ToString();

                        if (existingFullName != null)
                        {
                            MessageBox.Show($"Student number {studentNumber} is already registered as {existingFullName}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while checking the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {
                using (MySqlConnection conn = new MySqlConnection("Server=localhost;Database=student_record_system;User=root;Password=;"))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentNumber", studentNumber);
                        cmd.Parameters.AddWithValue("@FullName", fullName);
                        cmd.Parameters.AddWithValue("@Age", age);
                        cmd.Parameters.AddWithValue("@BirthDate", birthDate);
                        cmd.Parameters.AddWithValue("@Address", address);
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Student record added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                            DisableFields();
                            AddBtn.Text = "Add";
                            AddBtn.Click -= SaveBtn_Click;
                            AddBtn.Click += AddBtn_Click;
                            CancelBtn.Enabled = false;

                            _currentGeneratedStudentNumber = null;
                        }
                        else
                        {
                            MessageBox.Show("Error occurred while adding student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadStudentData()
        {
            string query = "SELECT student_no, full_name, age, birth_date, address FROM student_information";

            try
            {
                using (MySqlConnection conn = new MySqlConnection("Server=localhost;Database=student_record_system;User=root;Password=;"))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                        dataGridView1.Columns["student_no"].HeaderText = "Student Number";
                        dataGridView1.Columns["full_name"].HeaderText = "Full Name";
                        dataGridView1.Columns["birth_date"].HeaderText = "Birth Date";
                        dataGridView1.Columns["age"].HeaderText = "Age";
                        dataGridView1.Columns["address"].HeaderText = "Address";


                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                        dataGridView1.Refresh();

                        if (dataTable.Rows.Count > 0)
                        {
                            EditBtn.Enabled = false;
                            DeleteBtn.Enabled = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the student data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(StudentNumberField.Text.Trim(), out int studentNumber))
            {
                MessageBox.Show("Please enter a valid student number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query;

            if (studentNumber == 0)
            {
                query = "SELECT student_no, full_name, age, birth_date, address FROM student_information";
            }
            else
            {
                query = "SELECT student_no, full_name, age, birth_date, address FROM student_information WHERE student_no = @StudentNumber";
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection("Server=localhost;Database=student_record_system;User=root;Password=;"))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (studentNumber != 0)
                        {
                            cmd.Parameters.AddWithValue("@StudentNumber", studentNumber);
                        }

                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dataTable;
                            dataGridView1.Columns["student_no"].HeaderText = "Student Number";
                            dataGridView1.Columns["full_name"].HeaderText = "Full Name";
                            dataGridView1.Columns["birth_date"].HeaderText = "Birth Date";
                            dataGridView1.Columns["age"].HeaderText = "Age";
                            dataGridView1.Columns["address"].HeaderText = "Address";

                            EditBtn.Enabled = true;
                            DeleteBtn.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("No students found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            LoadStudentData();
                            EditBtn.Enabled = false;
                            DeleteBtn.Enabled = false;
                        }

                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                        dataGridView1.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching for the student(s): " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isEditing = false;
        private void SaveChanges()
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["student_no"].Value != null)
                    {
                        string studentNo = row.Cells["student_no"].Value.ToString();
                        string fullName = row.Cells["full_name"].Value.ToString();
                        string ageText = row.Cells["age"].Value.ToString();
                        string address = row.Cells["address"].Value.ToString();
                        int age = 0;
                        if (!int.TryParse(ageText, out age) || age <= 0)
                        {
                            MessageBox.Show("Invalid age value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        DateTime birthDate;
                        if (row.Cells["birth_date"].Value != DBNull.Value)
                        {
                            birthDate = Convert.ToDateTime(row.Cells["birth_date"].Value);
                        }
                        else
                        {
                            birthDate = DateTime.MinValue;
                        }

                        string updateQuery = "UPDATE student_information SET full_name = @FullName, age = @Age, birth_date = @BirthDate, address = @Address WHERE student_no = @StudentNo";

                        using (MySqlConnection conn = new MySqlConnection("Server=localhost;Database=student_record_system;User=root;Password=;"))
                        {
                            conn.Open();

                            using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@FullName", fullName);
                                cmd.Parameters.AddWithValue("@Age", age);
                                cmd.Parameters.AddWithValue("@BirthDate", (object)birthDate ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("@Address", address);
                                cmd.Parameters.AddWithValue("@StudentNo", studentNo);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
                LoadStudentData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving changes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (row.IsNewRow)
                    {
                        MessageBox.Show("Please select a student to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue;
                    }


                    string fullName = row.Cells["full_name"].Value.ToString();

                    DialogResult result = MessageBox.Show($"Are you sure you want to delete student {fullName}?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            string deleteQuery = "DELETE FROM student_information WHERE full_name = @FullName";
                            using (MySqlConnection conn = new MySqlConnection("Server=localhost;Database=student_record_system;User=root;Password=;"))
                            {
                                conn.Open();
                                using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                                {
                                    cmd.Parameters.AddWithValue("@FullName", fullName);
                                    cmd.ExecuteNonQuery();
                                }
                            }

                            LoadStudentData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred while deleting the student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                dataGridView1.ReadOnly = false;
                dataGridView1.Columns["student_no"].ReadOnly = true;
                EditBtn.Text = "Save";
                isEditing = true;
            }
            else
            {
                SaveChanges();
                EditBtn.Text = "Edit";
                dataGridView1.ReadOnly = true;
                isEditing = false;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            if (AddBtn.Text == "Save")
            {
                ClearFields();
                DisableFields();
                AddBtn.Text = "Add";
                AddBtn.Click -= SaveBtn_Click;
                AddBtn.Click += AddBtn_Click;
                SearchBtn.Enabled = true;

                CancelBtn.Enabled = false;
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            LoadStudentData();
        }
    }
}