namespace Course
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            StartPicture = new PictureBox();
            buttonRegistration = new Button();
            buttonLogin = new Button();
            buttonViewProperies = new Button();
            ((System.ComponentModel.ISupportInitialize)StartPicture).BeginInit();
            SuspendLayout();
            // 
            // StartPicture
            // 
            StartPicture.Dock = DockStyle.Fill;
            StartPicture.Image = (Image)resources.GetObject("StartPicture.Image");
            StartPicture.Location = new Point(0, 0);
            StartPicture.Name = "StartPicture";
            StartPicture.Size = new Size(1902, 1033);
            StartPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            StartPicture.TabIndex = 0;
            StartPicture.TabStop = false;
            // 
            // buttonRegistration
            // 
            buttonRegistration.BackColor = SystemColors.ButtonHighlight;
            buttonRegistration.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRegistration.ForeColor = SystemColors.MenuHighlight;
            buttonRegistration.Location = new Point(1683, 534);
            buttonRegistration.Name = "buttonRegistration";
            buttonRegistration.Size = new Size(189, 75);
            buttonRegistration.TabIndex = 1;
            buttonRegistration.Text = "Зареєструватися";
            buttonRegistration.UseVisualStyleBackColor = false;
            buttonRegistration.Click += buttonRegistration_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = SystemColors.ButtonHighlight;
            buttonLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogin.ForeColor = SystemColors.MenuHighlight;
            buttonLogin.Location = new Point(1683, 401);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(189, 75);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Увійти";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click_1;
            // 
            // buttonViewProperies
            // 
            buttonViewProperies.BackColor = SystemColors.ButtonHighlight;
            buttonViewProperies.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonViewProperies.ForeColor = SystemColors.MenuHighlight;
            buttonViewProperies.Location = new Point(1683, 265);
            buttonViewProperies.Name = "buttonViewProperies";
            buttonViewProperies.Size = new Size(189, 75);
            buttonViewProperies.TabIndex = 3;
            buttonViewProperies.Text = "Переглянути";
            buttonViewProperies.UseVisualStyleBackColor = false;
            buttonViewProperies.Click += buttonViewProperies_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(buttonViewProperies);
            Controls.Add(buttonLogin);
            Controls.Add(buttonRegistration);
            Controls.Add(StartPicture);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)StartPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox StartPicture;
        private Button buttonRegistration;
        private Button buttonLogin;
        private Button buttonViewProperies;
    }
}