namespace Course
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            buttonRegistration = new Button();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonRegistration
            // 
            buttonRegistration.BackColor = SystemColors.ButtonHighlight;
            buttonRegistration.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRegistration.ForeColor = SystemColors.MenuHighlight;
            buttonRegistration.Location = new Point(854, 834);
            buttonRegistration.Name = "buttonRegistration";
            buttonRegistration.Size = new Size(199, 88);
            buttonRegistration.TabIndex = 0;
            buttonRegistration.Text = "Зареєструватися";
            buttonRegistration.UseVisualStyleBackColor = false;
            buttonRegistration.Click += buttonRegistration_Click;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(844, 300);
            textBoxName.Multiline = true;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(376, 45);
            textBoxName.TabIndex = 1;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSurname.Location = new Point(844, 434);
            textBoxSurname.Multiline = true;
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(376, 45);
            textBoxSurname.TabIndex = 2;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(844, 555);
            textBoxLogin.Multiline = true;
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(376, 45);
            textBoxLogin.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(844, 689);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(376, 45);
            textBoxPassword.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1902, 1033);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.MenuHighlight;
            button2.Location = new Point(22, 25);
            button2.Name = "button2";
            button2.Size = new Size(147, 61);
            button2.TabIndex = 6;
            button2.Text = "Повернутися";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(button2);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxName);
            Controls.Add(buttonRegistration);
            Controls.Add(pictureBox1);
            Name = "RegistrationForm";
            Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRegistration;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private PictureBox pictureBox1;
        private Button button2;
    }
}