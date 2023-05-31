using Course.Classes;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course
{
    public partial class BookingForm : Form
    {
        private string path = "Booking.json";
        private string path2 = "Property.json";
        public BookingForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            dataGridView1.Columns["Column1"].Visible = false;
            ComboBox();
        }

        public void ComboBox()
        {
            List<HousingType> housingTypes = new List<HousingType>();
            HousingType housingType1 = HousingType.Дім;
            HousingType housingType2 = HousingType.Готель;
            housingTypes.Add(housingType1);
            housingTypes.Add(housingType2);
            comboBoxType.DataSource = housingTypes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = 0;
            BookingRepos.ReadTheBooking(path);
            PropertyRepos.ReadTheProperty(path2);
            PropertyRepos propertyRepos = new PropertyRepos();
            RegistredUserRepos repos = new RegistredUserRepos();
            if (string.IsNullOrWhiteSpace(textBoxCity.Text) || textBoxCity.Text.Any(char.IsDigit))
            {

                MessageBox.Show("Некоректно введена назва міста", "Помилка!", MessageBoxButtons.
                 OK, MessageBoxIcon.Information);
                textBoxCity.Text = "";
                return;
            }
            if (dateTimePicker1.Value > dateTimePicker2.Value || dateTimePicker1.Value == dateTimePicker2.Value)
            {
                MessageBox.Show("Некоректно обрано дати початку і кінця заїзду", "Помилка!", MessageBoxButtons.
                OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxPeopleCapacity.Text))
            {

                MessageBox.Show("Некоректно введена кількість людей", "Помилка!", MessageBoxButtons.
                 OK, MessageBoxIcon.Information);
                textBoxPeopleCapacity.Text = "";
                return;
            }
            else if (!int.TryParse(textBoxPeopleCapacity.Text, out number) || number < 0 || number > 15)
            {

                MessageBox.Show("Некоректно введена кількість людей", "Помилка!", MessageBoxButtons.
                 OK, MessageBoxIcon.Information);
                textBoxPeopleCapacity.Text = "";
                return;
            }
            string city = textBoxCity.Text;
            HousingType selectedHousingType = (HousingType)comboBoxType.SelectedItem;
            int selectedCapacity = int.Parse(textBoxPeopleCapacity.Text);

           

            var availableBookings = MainForm.registredUser.ViewProperties()
                .Where(property => property.City == city && property.HousingType == selectedHousingType && property.PeopleCapacity == selectedCapacity && property.IsAvailable)
                .ToList();

            dataGridView1.Columns["Column1"].Visible = true;
            // Очистка DataGridView
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            // Привязка нового списка бронирований к DataGridView
            dataGridView1.DataSource = availableBookings;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                Property property = row.DataBoundItem as Property;
                if (property != null)
                {

                    // Расчет цены для каждого жилья
                    decimal price = (dateTimePicker2.Value - dateTimePicker1.Value).Days * property.PriceNight;

                    // Установка значения в соответствующую ячейку
                    DataGridViewCell priceCell = row.Cells["Column2"];
                    priceCell.Value = price;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)row.Cells["Column1"];
                if (checkBoxCell.Value != null && checkBoxCell.Value is bool isChecked && isChecked)
                {
                    int propertyId = (int)row.Cells["idDataGridViewTextBoxColumn"].Value;
                    Property property = PropertyRepos.GetPropertyById(propertyId);

                    // Проверяем, что свойство получено успешно
                    if (property != null)
                    {
                        DateTime checkInDate = dateTimePicker1.Value;
                        DateTime checkOutDate = dateTimePicker2.Value;
                        int peopleCapacity = int.Parse(textBoxPeopleCapacity.Text);

                        MainForm.registredUser.BookProperty(property, checkInDate, checkOutDate, peopleCapacity, MainForm.registredUser);
                    }
                }
            }
            PropertyRepos.SavingTheProperty(path2);
            BookingRepos.SavingTheBooking(path);

            dataGridView1.DataSource = null;
            dataGridView1.Columns["Column1"].Visible = false;
            


        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            RegistredUserForm registredUserForm = new RegistredUserForm();
            this.Hide();
            registredUserForm.Show();
        }
    }
}
