namespace SRS
{
    partial class StudentRecordSystemView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            StudentRecordDetailsTitle = new Label();
            LogoutLink = new LinkLabel();
            AddBtn = new Button();
            EditBtn = new Button();
            SearchBtn = new Button();
            StudentNumberField = new TextBox();
            DeleteBtn = new Button();
            CancelBtn = new Button();
            dataGridView1 = new DataGridView();
            AddStudentNumberField = new TextBox();
            NameField = new TextBox();
            AgeField = new TextBox();
            BirthDatePicker = new DateTimePicker();
            BirthDateLabel = new Label();
            AddressField = new TextBox();
            RefreshBtn = new Button();
            viewEnrollmentButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // StudentRecordDetailsTitle
            // 
            StudentRecordDetailsTitle.AutoSize = true;
            StudentRecordDetailsTitle.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            StudentRecordDetailsTitle.ForeColor = SystemColors.ControlDarkDark;
            StudentRecordDetailsTitle.Location = new Point(377, 0);
            StudentRecordDetailsTitle.Name = "StudentRecordDetailsTitle";
            StudentRecordDetailsTitle.Size = new Size(431, 51);
            StudentRecordDetailsTitle.TabIndex = 0;
            StudentRecordDetailsTitle.Text = "Student Record Details";
            // 
            // LogoutLink
            // 
            LogoutLink.AutoSize = true;
            LogoutLink.Font = new Font("Segoe UI", 10F);
            LogoutLink.LinkColor = Color.Black;
            LogoutLink.Location = new Point(997, 80);
            LogoutLink.Name = "LogoutLink";
            LogoutLink.Size = new Size(53, 19);
            LogoutLink.TabIndex = 1;
            LogoutLink.TabStop = true;
            LogoutLink.Text = "Logout";
            LogoutLink.LinkClicked += LogoutLink_LinkClicked;
            // 
            // AddBtn
            // 
            AddBtn.Font = new Font("Segoe UI", 10F);
            AddBtn.Location = new Point(765, 558);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(120, 35);
            AddBtn.TabIndex = 2;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.Font = new Font("Segoe UI", 10F);
            EditBtn.Location = new Point(639, 141);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(120, 35);
            EditBtn.TabIndex = 3;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // SearchBtn
            // 
            SearchBtn.Font = new Font("Segoe UI", 10F);
            SearchBtn.Location = new Point(72, 141);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(120, 35);
            SearchBtn.TabIndex = 4;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // StudentNumberField
            // 
            StudentNumberField.Font = new Font("Segoe UI", 10F);
            StudentNumberField.Location = new Point(198, 147);
            StudentNumberField.Name = "StudentNumberField";
            StudentNumberField.PlaceholderText = "Student Number";
            StudentNumberField.Size = new Size(250, 25);
            StudentNumberField.TabIndex = 5;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Font = new Font("Segoe UI", 10F);
            DeleteBtn.Location = new Point(765, 141);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(120, 35);
            DeleteBtn.TabIndex = 6;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Font = new Font("Segoe UI", 10F);
            CancelBtn.Location = new Point(930, 558);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(120, 35);
            CancelBtn.TabIndex = 7;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(72, 187);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(978, 226);
            dataGridView1.TabIndex = 8;
            // 
            // AddStudentNumberField
            // 
            AddStudentNumberField.Font = new Font("Segoe UI", 10F);
            AddStudentNumberField.Location = new Point(72, 434);
            AddStudentNumberField.Name = "AddStudentNumberField";
            AddStudentNumberField.PlaceholderText = "Student Number";
            AddStudentNumberField.Size = new Size(250, 25);
            AddStudentNumberField.TabIndex = 9;
            // 
            // NameField
            // 
            NameField.Font = new Font("Segoe UI", 10F);
            NameField.Location = new Point(72, 480);
            NameField.Name = "NameField";
            NameField.PlaceholderText = "Full Name";
            NameField.Size = new Size(315, 25);
            NameField.TabIndex = 10;
            // 
            // AgeField
            // 
            AgeField.Font = new Font("Segoe UI", 10F);
            AgeField.Location = new Point(72, 526);
            AgeField.Name = "AgeField";
            AgeField.PlaceholderText = "Age";
            AgeField.Size = new Size(75, 25);
            AgeField.TabIndex = 11;
            // 
            // BirthDatePicker
            // 
            BirthDatePicker.Font = new Font("Segoe UI", 10F);
            BirthDatePicker.Location = new Point(187, 568);
            BirthDatePicker.Name = "BirthDatePicker";
            BirthDatePicker.Size = new Size(200, 25);
            BirthDatePicker.TabIndex = 12;
            // 
            // BirthDateLabel
            // 
            BirthDateLabel.AutoSize = true;
            BirthDateLabel.Font = new Font("Segoe UI", 10F);
            BirthDateLabel.ForeColor = SystemColors.ControlDarkDark;
            BirthDateLabel.Location = new Point(72, 574);
            BirthDateLabel.Name = "BirthDateLabel";
            BirthDateLabel.Size = new Size(71, 19);
            BirthDateLabel.TabIndex = 13;
            BirthDateLabel.Text = "Birth Date";
            // 
            // AddressField
            // 
            AddressField.Font = new Font("Segoe UI", 10F);
            AddressField.Location = new Point(508, 434);
            AddressField.Multiline = true;
            AddressField.Name = "AddressField";
            AddressField.PlaceholderText = "Address";
            AddressField.Size = new Size(542, 100);
            AddressField.TabIndex = 14;
            // 
            // RefreshBtn
            // 
            RefreshBtn.Font = new Font("Segoe UI", 10F);
            RefreshBtn.Location = new Point(930, 141);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(120, 35);
            RefreshBtn.TabIndex = 15;
            RefreshBtn.Text = "Refresh";
            RefreshBtn.UseVisualStyleBackColor = true;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // viewEnrollmentButton
            // 
            viewEnrollmentButton.Enabled = false;
            viewEnrollmentButton.Font = new Font("Segoe UI", 10F);
            viewEnrollmentButton.Location = new Point(454, 141);
            viewEnrollmentButton.Name = "viewEnrollmentButton";
            viewEnrollmentButton.Size = new Size(150, 35);
            viewEnrollmentButton.TabIndex = 0;
            viewEnrollmentButton.Text = "View Enrollments";
            viewEnrollmentButton.Click += ViewEnrollmentButton_Click;
            // 
            // StudentRecordSystemView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 641);
            Controls.Add(viewEnrollmentButton);
            Controls.Add(RefreshBtn);
            Controls.Add(AddressField);
            Controls.Add(BirthDateLabel);
            Controls.Add(BirthDatePicker);
            Controls.Add(AgeField);
            Controls.Add(NameField);
            Controls.Add(AddStudentNumberField);
            Controls.Add(dataGridView1);
            Controls.Add(CancelBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(StudentNumberField);
            Controls.Add(SearchBtn);
            Controls.Add(EditBtn);
            Controls.Add(AddBtn);
            Controls.Add(LogoutLink);
            Controls.Add(StudentRecordDetailsTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentRecordSystemView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentRecordSystemView";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label StudentRecordDetailsTitle;
        private LinkLabel LogoutLink;
        private Button AddBtn;
        private Button EditBtn;
        private Button SearchBtn;
        private TextBox StudentNumberField;
        private Button DeleteBtn;
        private Button CancelBtn;
        private DataGridView dataGridView1;
        private TextBox AddStudentNumberField;
        private TextBox NameField;
        private TextBox AgeField;
        private DateTimePicker BirthDatePicker;
        private Label BirthDateLabel;
        private TextBox AddressField;
        private Button RefreshBtn;
        private Button viewEnrollmentButton;
    }
}