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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // StudentRecordDetailsTitle
            // 
            StudentRecordDetailsTitle.AutoSize = true;
            StudentRecordDetailsTitle.Font = new Font("Segoe UI", 30F);
            StudentRecordDetailsTitle.ForeColor = SystemColors.ControlDarkDark;
            StudentRecordDetailsTitle.Location = new Point(377, 0);
            StudentRecordDetailsTitle.Name = "StudentRecordDetailsTitle";
            StudentRecordDetailsTitle.Size = new Size(427, 54);
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
            AddBtn.Location = new Point(882, 552);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 23);
            AddBtn.TabIndex = 2;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.Location = new Point(639, 144);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(75, 23);
            EditBtn.TabIndex = 3;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(127, 144);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(75, 23);
            SearchBtn.TabIndex = 4;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // StudentNumberField
            // 
            StudentNumberField.Location = new Point(208, 144);
            StudentNumberField.Name = "StudentNumberField";
            StudentNumberField.PlaceholderText = "Student Number";
            StudentNumberField.Size = new Size(285, 23);
            StudentNumberField.TabIndex = 5;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(729, 144);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(75, 23);
            DeleteBtn.TabIndex = 6;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(975, 552);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(75, 23);
            CancelBtn.TabIndex = 7;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(127, 187);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(923, 226);
            dataGridView1.TabIndex = 8;
            // 
            // AddStudentNumberField
            // 
            AddStudentNumberField.Location = new Point(127, 434);
            AddStudentNumberField.Name = "AddStudentNumberField";
            AddStudentNumberField.PlaceholderText = "Student Number";
            AddStudentNumberField.Size = new Size(183, 23);
            AddStudentNumberField.TabIndex = 9;
            // 
            // NameField
            // 
            NameField.Location = new Point(127, 474);
            NameField.Name = "NameField";
            NameField.PlaceholderText = "Full Name";
            NameField.Size = new Size(315, 23);
            NameField.TabIndex = 10;
            // 
            // AgeField
            // 
            AgeField.Location = new Point(127, 511);
            AgeField.Name = "AgeField";
            AgeField.PlaceholderText = "Age";
            AgeField.Size = new Size(75, 23);
            AgeField.TabIndex = 11;
            // 
            // BirthDatePicker
            // 
            BirthDatePicker.Location = new Point(192, 548);
            BirthDatePicker.Name = "BirthDatePicker";
            BirthDatePicker.Size = new Size(200, 23);
            BirthDatePicker.TabIndex = 12;
            // 
            // BirthDateLabel
            // 
            BirthDateLabel.AutoSize = true;
            BirthDateLabel.ForeColor = SystemColors.ControlDarkDark;
            BirthDateLabel.Location = new Point(127, 554);
            BirthDateLabel.Name = "BirthDateLabel";
            BirthDateLabel.Size = new Size(59, 15);
            BirthDateLabel.TabIndex = 13;
            BirthDateLabel.Text = "Birth Date";
            // 
            // AddressField
            // 
            AddressField.Location = new Point(508, 434);
            AddressField.Multiline = true;
            AddressField.Name = "AddressField";
            AddressField.PlaceholderText = "Address";
            AddressField.Size = new Size(542, 100);
            AddressField.TabIndex = 14;
            // 
            // RefreshBtn
            // 
            RefreshBtn.Location = new Point(975, 143);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(75, 23);
            RefreshBtn.TabIndex = 15;
            RefreshBtn.Text = "Refresh";
            RefreshBtn.UseVisualStyleBackColor = true;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // StudentRecordSystemView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 606);
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
    }
}