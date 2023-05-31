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

namespace Course
{
    public partial class DeleteUserForm : Form
    {
        private string path =  "RegistredUsers.json";
        private string path2 = "Booking.json";
        private string path3 = "Property.json";
        public DeleteUserForm()
        {
            InitializeComponent();
            Administrator administrator = new Administrator();
            dataGridView1.DataSource = administrator.ViewUser();
        }


        private void buttonRemoveUser_Click(object sender, EventArgs e)
        {
            BookingRepos bookingRepos = new BookingRepos();
            RegistredUserRepos.ReadTheUsers(path);
            BookingRepos.ReadTheBooking(path2);
            PropertyRepos.ReadTheProperty(path3);
            Administrator administrator1 = new Administrator();
            for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView1.Rows[i];

                // Проверяем значение чекбокса
                if (row.Cells["Column1"] is DataGridViewCheckBoxCell checkBoxCell &&
                     checkBoxCell.Value is bool isChecked && isChecked)
                {
                    if (row.Cells["dataGridViewTextBoxColumn3"].Value is int userId && row.Cells["loginDataGridViewTextBoxColumn"].Value is string userName)// доправить
                    {
                        administrator1.DeleteUsers(userId);
                        var bookings = BookingRepos.GetAllBookings().Where(b => b.User == userName).ToList();
                        if (bookings != null)
                        {
                            foreach (var booking in bookings)
                            {
                                bookingRepos.RemoveBooking(booking);

                            }
                        }

                    }
                }
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = administrator1.ViewUser();
            RegistredUserRepos.SavingTheUsers(path);
            BookingRepos.SavingTheBooking(path2);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {

            AdministratorForm administratorForm = new AdministratorForm();
            this.Hide();
            administratorForm.Show();
        }
    }


}





