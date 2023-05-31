namespace Course
{
    partial class BookingForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingForm));
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            housingTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceNightDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            peopleCapacityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewCheckBoxColumn();
            propertyBindingSource = new BindingSource(components);
            dateTimePicker1 = new DateTimePicker();
            comboBoxType = new ComboBox();
            textBoxPeopleCapacity = new TextBox();
            button1 = new Button();
            button2 = new Button();
            dateTimePicker2 = new DateTimePicker();
            pictureBox1 = new PictureBox();
            textBoxCity = new TextBox();
            buttonExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)propertyBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, housingTypeDataGridViewTextBoxColumn, priceNightDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, peopleCapacityDataGridViewTextBoxColumn, Column2, Column1 });
            dataGridView1.DataSource = propertyBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(967, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(935, 466);
            dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Назва";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 80;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Адреса";
            addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            addressDataGridViewTextBoxColumn.Width = 88;
            // 
            // housingTypeDataGridViewTextBoxColumn
            // 
            housingTypeDataGridViewTextBoxColumn.DataPropertyName = "HousingType";
            housingTypeDataGridViewTextBoxColumn.HeaderText = "Тип житла";
            housingTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            housingTypeDataGridViewTextBoxColumn.Name = "housingTypeDataGridViewTextBoxColumn";
            housingTypeDataGridViewTextBoxColumn.ReadOnly = true;
            housingTypeDataGridViewTextBoxColumn.Width = 101;
            // 
            // priceNightDataGridViewTextBoxColumn
            // 
            priceNightDataGridViewTextBoxColumn.DataPropertyName = "PriceNight";
            priceNightDataGridViewTextBoxColumn.HeaderText = "Ціна за ніч";
            priceNightDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceNightDataGridViewTextBoxColumn.Name = "priceNightDataGridViewTextBoxColumn";
            priceNightDataGridViewTextBoxColumn.ReadOnly = true;
            priceNightDataGridViewTextBoxColumn.Width = 86;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Опис";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // peopleCapacityDataGridViewTextBoxColumn
            // 
            peopleCapacityDataGridViewTextBoxColumn.DataPropertyName = "PeopleCapacity";
            peopleCapacityDataGridViewTextBoxColumn.HeaderText = "Максимальна кількість людей";
            peopleCapacityDataGridViewTextBoxColumn.MinimumWidth = 6;
            peopleCapacityDataGridViewTextBoxColumn.Name = "peopleCapacityDataGridViewTextBoxColumn";
            peopleCapacityDataGridViewTextBoxColumn.ReadOnly = true;
            peopleCapacityDataGridViewTextBoxColumn.Width = 183;
            // 
            // Column2
            // 
            Column2.HeaderText = "Загальна ціна";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 124;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Забронювати";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // propertyBindingSource
            // 
            propertyBindingSource.DataSource = typeof(Classes.Property);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(282, 331);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(392, 38);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.Value = new DateTime(2023, 5, 22, 0, 0, 0, 0);
            // 
            // comboBoxType
            // 
            comboBoxType.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(382, 647);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(151, 39);
            comboBoxType.TabIndex = 2;
            // 
            // textBoxPeopleCapacity
            // 
            textBoxPeopleCapacity.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPeopleCapacity.Location = new Point(291, 790);
            textBoxPeopleCapacity.Multiline = true;
            textBoxPeopleCapacity.Name = "textBoxPeopleCapacity";
            textBoxPeopleCapacity.Size = new Size(343, 37);
            textBoxPeopleCapacity.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Location = new Point(351, 900);
            button1.Name = "button1";
            button1.Size = new Size(210, 86);
            button1.TabIndex = 4;
            button1.Text = "Знайти";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Highlight;
            button2.Location = new Point(1362, 684);
            button2.Name = "button2";
            button2.Size = new Size(210, 86);
            button2.TabIndex = 5;
            button2.Text = "Забронювати";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Location = new Point(282, 497);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(392, 38);
            dateTimePicker2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1902, 1033);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // textBoxCity
            // 
            textBoxCity.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCity.Location = new Point(301, 164);
            textBoxCity.Multiline = true;
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(343, 37);
            textBoxCity.TabIndex = 8;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = SystemColors.ButtonHighlight;
            buttonExit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExit.ForeColor = SystemColors.Highlight;
            buttonExit.Location = new Point(26, 22);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(162, 73);
            buttonExit.TabIndex = 9;
            buttonExit.Text = "Повернутися";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // BookingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(buttonExit);
            Controls.Add(textBoxCity);
            Controls.Add(dateTimePicker2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxPeopleCapacity);
            Controls.Add(comboBoxType);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Name = "BookingForm";
            Text = "BookingForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)propertyBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn roomsDataGridViewTextBoxColumn;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBoxType;
        private TextBox textBoxPeopleCapacity;
        private Button button1;
        private Button button2;
        private DateTimePicker dateTimePicker2;
        private BindingSource propertyBindingSource;
        private PictureBox pictureBox1;
        private TextBox textBoxCity;
        private Button buttonExit;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn housingTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceNightDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn peopleCapacityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewCheckBoxColumn Column1;
    }
}