namespace SRS
{
    partial class CourseEnrollmentView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            studentInfoGroup = new GroupBox();
            studentNameLabel = new Label();
            studentNumberLabel = new Label();
            enrolledCoursesGrid = new DataGridView();
            availableCoursesGrid = new DataGridView();
            enrollButton = new Button();
            addCourseButton = new Button();
            label1 = new Label();
            label2 = new Label();
            closeButton = new Button();
            studentInfoGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)enrolledCoursesGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)availableCoursesGrid).BeginInit();
            SuspendLayout();
            // 
            // studentInfoGroup
            // 
            studentInfoGroup.Controls.Add(studentNameLabel);
            studentInfoGroup.Controls.Add(studentNumberLabel);
            studentInfoGroup.Location = new Point(14, 14);
            studentInfoGroup.Margin = new Padding(4, 3, 4, 3);
            studentInfoGroup.Name = "studentInfoGroup";
            studentInfoGroup.Padding = new Padding(4, 3, 4, 3);
            studentInfoGroup.Size = new Size(653, 81);
            studentInfoGroup.TabIndex = 0;
            studentInfoGroup.TabStop = false;
            studentInfoGroup.Text = "Student Information";
            // 
            // studentNameLabel
            // 
            studentNameLabel.AutoSize = true;
            studentNameLabel.Font = new Font("Microsoft Sans Serif", 10F);
            studentNameLabel.Location = new Point(23, 46);
            studentNameLabel.Margin = new Padding(4, 0, 4, 0);
            studentNameLabel.Name = "studentNameLabel";
            studentNameLabel.Size = new Size(102, 17);
            studentNameLabel.TabIndex = 1;
            studentNameLabel.Text = "Student Name:";
            // 
            // studentNumberLabel
            // 
            studentNumberLabel.AutoSize = true;
            studentNumberLabel.Font = new Font("Microsoft Sans Serif", 10F);
            studentNumberLabel.Location = new Point(23, 23);
            studentNumberLabel.Margin = new Padding(4, 0, 4, 0);
            studentNumberLabel.Name = "studentNumberLabel";
            studentNumberLabel.Size = new Size(115, 17);
            studentNumberLabel.TabIndex = 0;
            studentNumberLabel.Text = "Student Number:";
            // 
            // enrolledCoursesGrid
            // 
            enrolledCoursesGrid.AllowUserToAddRows = false;
            enrolledCoursesGrid.AllowUserToDeleteRows = false;
            enrolledCoursesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            enrolledCoursesGrid.Location = new Point(14, 162);
            enrolledCoursesGrid.Margin = new Padding(4, 3, 4, 3);
            enrolledCoursesGrid.Name = "enrolledCoursesGrid";
            enrolledCoursesGrid.ReadOnly = true;
            enrolledCoursesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            enrolledCoursesGrid.Size = new Size(653, 231);
            enrolledCoursesGrid.TabIndex = 1;
            // 
            // availableCoursesGrid
            // 
            availableCoursesGrid.AllowUserToAddRows = false;
            availableCoursesGrid.AllowUserToDeleteRows = false;
            availableCoursesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            availableCoursesGrid.Location = new Point(14, 438);
            availableCoursesGrid.Margin = new Padding(4, 3, 4, 3);
            availableCoursesGrid.Name = "availableCoursesGrid";
            availableCoursesGrid.ReadOnly = true;
            availableCoursesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            availableCoursesGrid.Size = new Size(653, 231);
            availableCoursesGrid.TabIndex = 2;
            // 
            // enrollButton
            // 
            enrollButton.Location = new Point(525, 681);
            enrollButton.Margin = new Padding(4, 3, 4, 3);
            enrollButton.Name = "enrollButton";
            enrollButton.Size = new Size(140, 35);
            enrollButton.TabIndex = 3;
            enrollButton.Text = "Enroll Selected";
            enrollButton.UseVisualStyleBackColor = true;
            enrollButton.Click += EnrollButton_Click;
            // 
            // addCourseButton
            // 
            addCourseButton.Location = new Point(14, 681);
            addCourseButton.Margin = new Padding(4, 3, 4, 3);
            addCourseButton.Name = "addCourseButton";
            addCourseButton.Size = new Size(140, 35);
            addCourseButton.TabIndex = 4;
            addCourseButton.Text = "Add New Course";
            addCourseButton.UseVisualStyleBackColor = true;
            addCourseButton.Click += AddCourseButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F);
            label1.Location = new Point(14, 138);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 17);
            label1.TabIndex = 5;
            label1.Text = "Enrolled Courses:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F);
            label2.Location = new Point(14, 415);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 17);
            label2.TabIndex = 6;
            label2.Text = "Available Courses:";
            // 
            // closeButton
            // 
            closeButton.Location = new Point(373, 681);
            closeButton.Margin = new Padding(4, 3, 4, 3);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(140, 35);
            closeButton.TabIndex = 7;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += CloseButton_Click;
            // 
            // CourseEnrollmentView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 728);
            Controls.Add(closeButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(addCourseButton);
            Controls.Add(enrollButton);
            Controls.Add(availableCoursesGrid);
            Controls.Add(enrolledCoursesGrid);
            Controls.Add(studentInfoGroup);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "CourseEnrollmentView";
            Text = "Course Enrollment";
            Load += CourseEnrollmentView_Load;
            studentInfoGroup.ResumeLayout(false);
            studentInfoGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)enrolledCoursesGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)availableCoursesGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox studentInfoGroup;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.Label studentNumberLabel;
        private System.Windows.Forms.DataGridView enrolledCoursesGrid;
        private System.Windows.Forms.DataGridView availableCoursesGrid;
        private System.Windows.Forms.Button enrollButton;
        private System.Windows.Forms.Button addCourseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button closeButton;
    }
}