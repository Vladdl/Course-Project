namespace Course
{
    partial class RegistredUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistredUserForm));
            buttonExit = new Button();
            buttonAddProperty = new Button();
            buttonBookingProperty = new Button();
            pictureBox1 = new PictureBox();
            buttonViewBookings = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonExit
            // 
            buttonExit.BackColor = SystemColors.ButtonHighlight;
            buttonExit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExit.ForeColor = SystemColors.Highlight;
            buttonExit.Location = new Point(818, 960);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(214, 73);
            buttonExit.TabIndex = 0;
            buttonExit.Text = "Вихід";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonAddProperty
            // 
            buttonAddProperty.BackColor = SystemColors.ButtonHighlight;
            buttonAddProperty.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddProperty.ForeColor = SystemColors.MenuHighlight;
            buttonAddProperty.Location = new Point(966, 715);
            buttonAddProperty.Name = "buttonAddProperty";
            buttonAddProperty.Size = new Size(162, 89);
            buttonAddProperty.TabIndex = 1;
            buttonAddProperty.Text = "Реєстрування Житла";
            buttonAddProperty.UseVisualStyleBackColor = false;
            buttonAddProperty.Click += buttonAddProperty_Click;
            // 
            // buttonBookingProperty
            // 
            buttonBookingProperty.BackColor = SystemColors.ButtonHighlight;
            buttonBookingProperty.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBookingProperty.ForeColor = SystemColors.MenuHighlight;
            buttonBookingProperty.Location = new Point(713, 715);
            buttonBookingProperty.Name = "buttonBookingProperty";
            buttonBookingProperty.Size = new Size(161, 89);
            buttonBookingProperty.TabIndex = 4;
            buttonBookingProperty.Text = "Забронювати";
            buttonBookingProperty.UseVisualStyleBackColor = false;
            buttonBookingProperty.Click += buttonBookingProperty_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1902, 1033);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // buttonViewBookings
            // 
            buttonViewBookings.BackColor = SystemColors.ButtonHighlight;
            buttonViewBookings.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonViewBookings.ForeColor = SystemColors.MenuHighlight;
            buttonViewBookings.Location = new Point(798, 415);
            buttonViewBookings.Name = "buttonViewBookings";
            buttonViewBookings.Size = new Size(248, 104);
            buttonViewBookings.TabIndex = 6;
            buttonViewBookings.Text = "Мої Бронювання";
            buttonViewBookings.UseVisualStyleBackColor = false;
            buttonViewBookings.Click += buttonViewBookings_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoEllipsis = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(804, 315);
            label1.Name = "label1";
            label1.Size = new Size(242, 45);
            label1.TabIndex = 7;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegistredUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(label1);
            Controls.Add(buttonViewBookings);
            Controls.Add(buttonBookingProperty);
            Controls.Add(buttonAddProperty);
            Controls.Add(buttonExit);
            Controls.Add(pictureBox1);
            Name = "RegistredUserForm";
            Text = "RegistredUserForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonExit;
        private Button buttonAddProperty;
        private Button buttonBookingProperty;
        private PictureBox pictureBox1;
        private Button buttonViewBookings;
        private Label label1;
    }
}