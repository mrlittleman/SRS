namespace SRS
{
    partial class LoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            LoginImage = new PictureBox();
            LoginTitle = new Label();
            UserField = new TextBox();
            PasswordField = new TextBox();
            LoginButton = new Button();
            ((System.ComponentModel.ISupportInitialize)LoginImage).BeginInit();
            SuspendLayout();
            // 
            // LoginImage
            // 
            LoginImage.BackgroundImage = (Image)resources.GetObject("LoginImage.BackgroundImage");
            LoginImage.Location = new Point(523, 84);
            LoginImage.Name = "LoginImage";
            LoginImage.Size = new Size(420, 420);
            LoginImage.TabIndex = 0;
            LoginImage.TabStop = false;
            // 
            // LoginTitle
            // 
            LoginTitle.AutoSize = true;
            LoginTitle.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            LoginTitle.Location = new Point(193, 148);
            LoginTitle.Name = "LoginTitle";
            LoginTitle.Size = new Size(127, 54);
            LoginTitle.TabIndex = 1;
            LoginTitle.Text = "Login";
            // 
            // UserField
            // 
            UserField.BorderStyle = BorderStyle.FixedSingle;
            UserField.Font = new Font("Segoe UI", 10F);
            UserField.Location = new Point(87, 249);
            UserField.Margin = new Padding(5);
            UserField.Name = "UserField";
            UserField.PlaceholderText = " User";
            UserField.Size = new Size(358, 25);
            UserField.TabIndex = 2;
            UserField.WordWrap = false;
            // 
            // PasswordField
            // 
            PasswordField.BorderStyle = BorderStyle.FixedSingle;
            PasswordField.Font = new Font("Segoe UI", 10F);
            PasswordField.Location = new Point(87, 298);
            PasswordField.Margin = new Padding(5);
            PasswordField.Name = "PasswordField";
            PasswordField.PasswordChar = '*';
            PasswordField.PlaceholderText = " Password";
            PasswordField.Size = new Size(358, 25);
            PasswordField.TabIndex = 3;
            PasswordField.WordWrap = false;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(108, 99, 255);
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Segoe UI", 10F);
            LoginButton.ForeColor = Color.Transparent;
            LoginButton.Location = new Point(87, 349);
            LoginButton.Margin = new Padding(0);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(358, 29);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 600);
            Controls.Add(LoginButton);
            Controls.Add(PasswordField);
            Controls.Add(UserField);
            Controls.Add(LoginTitle);
            Controls.Add(LoginImage);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "LoginView";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)LoginImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox LoginImage;
        private Label LoginTitle;
        private TextBox UserField;
        private TextBox PasswordField;
        private Button LoginButton;
    }
}