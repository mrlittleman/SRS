namespace SRS
{
    partial class AddCourseForm
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
            courseCodeLabel = new Label();
            courseCodeText = new TextBox();
            courseNameLabel = new Label();
            courseNameText = new TextBox();
            creditHoursLabel = new Label();
            creditHoursNumeric = new NumericUpDown();
            descriptionLabel = new Label();
            descriptionText = new TextBox();
            saveButton = new Button();
            cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)creditHoursNumeric).BeginInit();
            SuspendLayout();
            // 
            // courseCodeLabel
            // 
            courseCodeLabel.AutoSize = true;
            courseCodeLabel.Location = new Point(23, 23);
            courseCodeLabel.Margin = new Padding(4, 0, 4, 0);
            courseCodeLabel.Name = "courseCodeLabel";
            courseCodeLabel.Size = new Size(78, 15);
            courseCodeLabel.TabIndex = 0;
            courseCodeLabel.Text = "Course Code:";
            // 
            // courseCodeText
            // 
            courseCodeText.Location = new Point(140, 20);
            courseCodeText.Margin = new Padding(4, 3, 4, 3);
            courseCodeText.Name = "courseCodeText";
            courseCodeText.Size = new Size(233, 23);
            courseCodeText.TabIndex = 1;
            // 
            // courseNameLabel
            // 
            courseNameLabel.AutoSize = true;
            courseNameLabel.Location = new Point(23, 58);
            courseNameLabel.Margin = new Padding(4, 0, 4, 0);
            courseNameLabel.Name = "courseNameLabel";
            courseNameLabel.Size = new Size(82, 15);
            courseNameLabel.TabIndex = 2;
            courseNameLabel.Text = "Course Name:";
            // 
            // courseNameText
            // 
            courseNameText.Location = new Point(140, 54);
            courseNameText.Margin = new Padding(4, 3, 4, 3);
            courseNameText.Name = "courseNameText";
            courseNameText.Size = new Size(233, 23);
            courseNameText.TabIndex = 3;
            // 
            // creditHoursLabel
            // 
            creditHoursLabel.AutoSize = true;
            creditHoursLabel.Location = new Point(23, 92);
            creditHoursLabel.Margin = new Padding(4, 0, 4, 0);
            creditHoursLabel.Name = "creditHoursLabel";
            creditHoursLabel.Size = new Size(77, 15);
            creditHoursLabel.TabIndex = 4;
            creditHoursLabel.Text = "Credit Hours:";
            // 
            // creditHoursNumeric
            // 
            creditHoursNumeric.Location = new Point(140, 90);
            creditHoursNumeric.Margin = new Padding(4, 3, 4, 3);
            creditHoursNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            creditHoursNumeric.Name = "creditHoursNumeric";
            creditHoursNumeric.Size = new Size(70, 23);
            creditHoursNumeric.TabIndex = 5;
            creditHoursNumeric.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(23, 127);
            descriptionLabel.Margin = new Padding(4, 0, 4, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(70, 15);
            descriptionLabel.TabIndex = 6;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionText
            // 
            descriptionText.Location = new Point(140, 123);
            descriptionText.Margin = new Padding(4, 3, 4, 3);
            descriptionText.Multiline = true;
            descriptionText.Name = "descriptionText";
            descriptionText.Size = new Size(233, 115);
            descriptionText.TabIndex = 7;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(140, 254);
            saveButton.Margin = new Padding(4, 3, 4, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(88, 27);
            saveButton.TabIndex = 8;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(233, 254);
            cancelButton.Margin = new Padding(4, 3, 4, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(88, 27);
            cancelButton.TabIndex = 9;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // AddCourseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 300);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(descriptionText);
            Controls.Add(descriptionLabel);
            Controls.Add(creditHoursNumeric);
            Controls.Add(creditHoursLabel);
            Controls.Add(courseNameText);
            Controls.Add(courseNameLabel);
            Controls.Add(courseCodeText);
            Controls.Add(courseCodeLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddCourseForm";
            Text = "Add New Course";
            ((System.ComponentModel.ISupportInitialize)creditHoursNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label courseCodeLabel;
        private System.Windows.Forms.TextBox courseCodeText;
        private System.Windows.Forms.Label courseNameLabel;
        private System.Windows.Forms.TextBox courseNameText;
        private System.Windows.Forms.Label creditHoursLabel;
        private System.Windows.Forms.NumericUpDown creditHoursNumeric;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}