using Course.Classes;
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
    public partial class RegistredUserForm : Form
    {
        public RegistredUserForm()
        {
            InitializeComponent();
            label1.Text = MainForm.registredUser.Login;
        }



        private void buttonAddProperty_Click(object sender, EventArgs e)
        {
            PropertyForm propertyForm = new PropertyForm();
            this.Hide();
            propertyForm.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            MainForm mainnForm = new MainForm();
            this.Hide();
            mainnForm.Show();
        }

        private void buttonViewBookings_Click(object sender, EventArgs e)
        {
            ViewBookingsForUserForm viewBookingsForUserForm = new ViewBookingsForUserForm();
            this.Hide();
            viewBookingsForUserForm.Show();
        }

        private void buttonBookingProperty_Click(object sender, EventArgs e)
        {
            BookingForm bookingForm = new BookingForm();
            this.Hide();
            bookingForm.Show();
        }
    }
}
