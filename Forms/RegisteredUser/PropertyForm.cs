using Course;
using Course.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Course
{
    public partial class PropertyForm : Form
    {
        private string path = "Property.json";
        public PropertyForm()
        {
            InitializeComponent();
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



        private void buttonExit_Click(object sender, EventArgs e)
        {

            RegistredUserForm registredUserForm = new RegistredUserForm();
            this.Hide();
            registredUserForm.Show();
        }

        private void buttonRegistratiomProperty_Click(object sender, EventArgs e)
        {
            PropertyRepos.ReadTheProperty(path);
            if (string.IsNullOrWhiteSpace(textBoxName.Text) || textBoxName.TextLength < 2 || textBoxName.TextLength > 60)
            {

                MessageBox.Show("Некоректно введена назва", "Помилка!", MessageBoxButtons.
                 OK, MessageBoxIcon.Information);
                textBoxName.Text = "";
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxCity.Text) || textBoxCity.TextLength < 3 || textBoxCity.TextLength > 60 || textBoxCity.Text.Any(char.IsDigit))
            {

                MessageBox.Show("Некоректно введена назва міста", "Помилка!", MessageBoxButtons.
                 OK, MessageBoxIcon.Information);
                textBoxCity.Text = "";
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxAddres.Text) || textBoxAddres.TextLength < 5 || textBoxAddres.TextLength > 60)
            {

                MessageBox.Show("Некоректно введена адреса", "Помилка!", MessageBoxButtons.
                 OK, MessageBoxIcon.Information);
                textBoxAddres.Text = "";
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxPriceNight.Text))
            {

                MessageBox.Show("Некоректно введена ціна за ніч", "Помилка!", MessageBoxButtons.
                 OK, MessageBoxIcon.Information);
                textBoxPriceNight.Text = "";
                return;
            }
            else if (!int.TryParse(textBoxPriceNight.Text, out int number) || number < 0 || number > 10000)
            {

                MessageBox.Show("Некоректно введена ціна за ніч", "Помилка!", MessageBoxButtons.
                 OK, MessageBoxIcon.Information);
                textBoxPriceNight.Text = "";
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxPeopleCapacity.Text))
            {

                MessageBox.Show("Некоректно введена кількість людей", "Помилка!", MessageBoxButtons.
                 OK, MessageBoxIcon.Information);
                textBoxPeopleCapacity.Text = "";
                return;
            }
            else if (!int.TryParse(textBoxPeopleCapacity.Text, out int number) || number < 0 || number > 15)
            {

                MessageBox.Show("Некоректно введена кількість людей", "Помилка!", MessageBoxButtons.
                 OK, MessageBoxIcon.Information);
                textBoxPeopleCapacity.Text = "";
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxDescription.Text))
            {

                MessageBox.Show("Некоректно заповнений опис житла", "Помилка!", MessageBoxButtons.
                 OK, MessageBoxIcon.Information);
                textBoxDescription.Text = "";
                return;
            }
            string name = textBoxName.Text;
            string addres = textBoxAddres.Text;
            HousingType housingType = (HousingType)Enum.Parse(typeof(HousingType), comboBoxType.Text);
            decimal priceNight = decimal.Parse(textBoxPriceNight.Text);
            string description = textBoxDescription.Text;
            string city = textBoxCity.Text;
            int peopleCapacity = int.Parse(textBoxPeopleCapacity.Text);
            Property property = new Property(name, addres, housingType, priceNight, description, peopleCapacity, city);
            MainForm.registredUser.AddNewProperty(property);
            PropertyRepos.SavingTheProperty(path);
            MessageBox.Show("Вітаємо, ви успішно зареєструвало житло", "Повідомлення!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxName.Text = "";
            textBoxCity.Text = "";
            textBoxPeopleCapacity.Text = "";
            textBoxAddres.Text = "";
            textBoxPriceNight.Text = "";
            textBoxPeopleCapacity.Text = "";
            textBoxDescription.Text = "";
        }
    }
}
