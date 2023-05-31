using Course;
using Course.Classes;
using Microsoft.VisualBasic.ApplicationServices;
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

namespace Course
{
    public partial class ViewBookingsForUserForm : Form
    {
        private string path1 = "Booking.json";
        private string path2 = "Property.json";
        private string path3 = "RegistredUsers.json";
        public ViewBookingsForUserForm()
        {
            InitializeComponent();
            BookingRepos.ReadTheBooking(path1);
            PropertyRepos.ReadTheProperty(path2);
            RegistredUserRepos.ReadTheUsers(path3);
            RegistredUserRepos registredUserRepos = new RegistredUserRepos();
            BookingRepos bookingRepos = new BookingRepos();
            RegistredUser user = registredUserRepos.GetRegistredUserByUsername(MainForm.registredUser.Login);


            dataGridView1.DataSource = MainForm.registredUser.ViewBooking(MainForm.registredUser);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            RegistredUserForm registredUserForm = new RegistredUserForm();
            this.Hide();
            registredUserForm.Show();
        }

        private void buttonRemoveBooking_Click(object sender, EventArgs e)
        {

            BookingRepos.ReadTheBooking(path1);
            PropertyRepos.ReadTheProperty(path2);
            RegistredUserRepos.ReadTheUsers(path3);
            BookingRepos bookingRepos = new BookingRepos();
         
            for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView1.Rows[i];

                // Проверяем значение чекбокса
                if (row.Cells["Column1"] is DataGridViewCheckBoxCell checkBoxCell &&
                    checkBoxCell.Value is bool isChecked && isChecked)
                {
                    if (row.Cells["propertyDataGridViewTextBoxColumn"].Value is string propertyName)
                    {
                        var bookings = BookingRepos.GetAllBookings().Where(b => b.Property == propertyName).ToList();
                        if (bookings != null)
                        {
                            foreach (var booking in bookings)
                            {
                                MainForm.registredUser.CancelBooking(booking.Id);
                            }
                        }
                    }
                }
            }
           
            RegistredUserRepos.SavingTheUsers(path3);
            BookingRepos.SavingTheBooking(path1);
            PropertyRepos.SavingTheProperty(path2);

            dataGridView1.DataSource = null; // Очистка таблицы
            dataGridView1.DataSource = MainForm.registredUser.ViewBooking(MainForm.registredUser);

        }
    }
}
