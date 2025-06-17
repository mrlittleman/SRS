using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SRS
{
    public partial class CourseEnrollmentView : Form
    {
        private string studentNo;
        private string studentName;

        public CourseEnrollmentView(string studentNumber, string fullName)
        {
            InitializeComponent();
            this.studentNo = studentNumber;
            this.studentName = fullName;

            studentNumberLabel.Text += " " + studentNumber;
            studentNameLabel.Text += " " + fullName;

            LoadEnrolledCourses();
            LoadAvailableCourses();
        }

        private void LoadEnrolledCourses()
        {
            string query = @"SELECT e.enrollment_id, c.course_code, c.course_name, c.credit_hours, e.enrollment_date 
                            FROM student_enrollments e
                            JOIN courses c ON e.course_id = c.course_id
                            WHERE e.student_no = @StudentNo";

            try
            {
                using (MySqlConnection conn = new MySqlConnection("Server=localhost;Database=student_record_system;User=root;Password=;"))
                {
                    conn.Open();

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@StudentNo", studentNo);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    enrolledCoursesGrid.DataSource = dt;

                    if (enrolledCoursesGrid.Columns.Contains("enrollment_id"))
                        enrolledCoursesGrid.Columns["enrollment_id"].Visible = false;

                    // Rename column headers
                    enrolledCoursesGrid.Columns["course_code"].HeaderText = "Course Code";
                    enrolledCoursesGrid.Columns["course_name"].HeaderText = "Course Name";
                    enrolledCoursesGrid.Columns["credit_hours"].HeaderText = "Credit Hours";
                    enrolledCoursesGrid.Columns["enrollment_date"].HeaderText = "Enrollment Date";

                    enrolledCoursesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    enrolledCoursesGrid.AutoResizeColumns();
                    enrolledCoursesGrid.AutoResizeRows();
                    enrolledCoursesGrid.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
                    enrolledCoursesGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    enrolledCoursesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                    enrolledCoursesGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading enrolled courses: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAvailableCourses()
        {
            string query = @"SELECT c.course_id, c.course_code, c.course_name, c.credit_hours 
                           FROM courses c
                           WHERE c.course_id NOT IN (
                               SELECT course_id FROM student_enrollments 
                               WHERE student_no = @StudentNo
                           )";

            try
            {
                using (MySqlConnection conn = new MySqlConnection("Server=localhost;Database=student_record_system;User=root;Password=;"))
                {
                    conn.Open();

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@StudentNo", studentNo);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    availableCoursesGrid.DataSource = dt;

                    if (availableCoursesGrid.Columns.Contains("course_id"))
                        availableCoursesGrid.Columns["course_id"].Visible = false;

                    // Rename column headers
                    availableCoursesGrid.Columns["course_code"].HeaderText = "Course Code";
                    availableCoursesGrid.Columns["course_name"].HeaderText = "Course Name";
                    availableCoursesGrid.Columns["credit_hours"].HeaderText = "Credit Hours";

                    availableCoursesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    availableCoursesGrid.AutoResizeColumns();
                    availableCoursesGrid.AutoResizeRows();
                    availableCoursesGrid.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
                    availableCoursesGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    availableCoursesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                    availableCoursesGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading available courses: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EnrollButton_Click(object sender, EventArgs e)
        {
            if (availableCoursesGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a course to enroll in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string courseId = availableCoursesGrid.SelectedRows[0].Cells["course_id"].Value.ToString();
            string courseName = availableCoursesGrid.SelectedRows[0].Cells["course_name"].Value.ToString();

            string query = "INSERT INTO student_enrollments (student_no, course_id) VALUES (@StudentNo, @CourseId)";

            try
            {
                using (MySqlConnection conn = new MySqlConnection("Server=localhost;Database=student_record_system;User=root;Password=;"))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentNo", studentNo);
                        cmd.Parameters.AddWithValue("@CourseId", courseId);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show($"Successfully enrolled in {courseName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadEnrolledCourses();
                            LoadAvailableCourses();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error enrolling in course: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            AddCourseForm addCourseForm = new AddCourseForm();
            if (addCourseForm.ShowDialog() == DialogResult.OK)
            {
                LoadAvailableCourses();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CourseEnrollmentView_Load(object sender, EventArgs e)
        {

        }
    }
}
