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
    public partial class AdministratorVIewForm : Form
    {
        private string path = "Booking.json";
        private string path2 = "Property.json";
        private string path3 = "RegistredUsers.json";
        public AdministratorVIewForm()
        {
            BookingRepos.ReadTheBooking(path);
            PropertyRepos.ReadTheProperty(path2);
            RegistredUserRepos.ReadTheUsers(path3);
            InitializeComponent();
            Administrator administrator = new Administrator();
            dataGridView1.DataSource = administrator.ViewUser();
            dataGridView2.DataSource = administrator.ViewProperties();
            dataGridView3.DataSource = administrator.ViewBooking();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            AdministratorForm administratorForm = new AdministratorForm();
            this.Hide();
            administratorForm.Show();
        }
    }
}
