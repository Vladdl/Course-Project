namespace Course
{
    partial class PropertyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropertyForm));
            textBoxName = new TextBox();
            textBoxAddres = new TextBox();
            textBoxPriceNight = new TextBox();
            textBoxDescription = new TextBox();
            comboBoxType = new ComboBox();
            buttonRegistratiomProperty = new Button();
            textBoxPeopleCapacity = new TextBox();
            pictureBox1 = new PictureBox();
            buttonExit = new Button();
            textBoxCity = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(490, 141);
            textBoxName.Multiline = true;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(376, 45);
            textBoxName.TabIndex = 0;
            // 
            // textBoxAddres
            // 
            textBoxAddres.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddres.Location = new Point(490, 349);
            textBoxAddres.Multiline = true;
            textBoxAddres.Name = "textBoxAddres";
            textBoxAddres.Size = new Size(376, 45);
            textBoxAddres.TabIndex = 1;
            // 
            // textBoxPriceNight
            // 
            textBoxPriceNight.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPriceNight.Location = new Point(490, 558);
            textBoxPriceNight.Multiline = true;
            textBoxPriceNight.Name = "textBoxPriceNight";
            textBoxPriceNight.Size = new Size(376, 45);
            textBoxPriceNight.TabIndex = 3;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDescription.Location = new Point(1094, 207);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(708, 573);
            textBoxDescription.TabIndex = 5;
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(604, 458);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(151, 39);
            comboBoxType.TabIndex = 6;
            // 
            // buttonRegistratiomProperty
            // 
            buttonRegistratiomProperty.BackColor = SystemColors.ButtonHighlight;
            buttonRegistratiomProperty.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRegistratiomProperty.ForeColor = SystemColors.MenuHighlight;
            buttonRegistratiomProperty.Location = new Point(842, 877);
            buttonRegistratiomProperty.Name = "buttonRegistratiomProperty";
            buttonRegistratiomProperty.Size = new Size(218, 113);
            buttonRegistratiomProperty.TabIndex = 7;
            buttonRegistratiomProperty.Text = "Зареєструвати Житло";
            buttonRegistratiomProperty.UseVisualStyleBackColor = false;
            buttonRegistratiomProperty.Click += buttonRegistratiomProperty_Click;
            // 
            // textBoxPeopleCapacity
            // 
            textBoxPeopleCapacity.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPeopleCapacity.Location = new Point(490, 677);
            textBoxPeopleCapacity.Multiline = true;
            textBoxPeopleCapacity.Name = "textBoxPeopleCapacity";
            textBoxPeopleCapacity.Size = new Size(376, 45);
            textBoxPeopleCapacity.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1902, 1033);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = SystemColors.ButtonHighlight;
            buttonExit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExit.ForeColor = SystemColors.MenuHighlight;
            buttonExit.Location = new Point(12, 970);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(199, 63);
            buttonExit.TabIndex = 10;
            buttonExit.Text = "Повернутися";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // textBoxCity
            // 
            textBoxCity.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCity.Location = new Point(490, 247);
            textBoxCity.Multiline = true;
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(376, 45);
            textBoxCity.TabIndex = 11;
            // 
            // PropertyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(textBoxCity);
            Controls.Add(buttonExit);
            Controls.Add(textBoxPeopleCapacity);
            Controls.Add(buttonRegistratiomProperty);
            Controls.Add(comboBoxType);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxPriceNight);
            Controls.Add(textBoxAddres);
            Controls.Add(textBoxName);
            Controls.Add(pictureBox1);
            Name = "PropertyForm";
            Text = "PropertyForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxAddres;
        private TextBox textBoxPriceNight;
        private TextBox textBoxDescription;
        private ComboBox comboBoxType;
        private Button buttonRegistratiomProperty;
        private TextBox textBoxPeopleCapacity;
        private PictureBox pictureBox1;
        private Button buttonExit;
        private TextBox textBoxCity;
    }
}