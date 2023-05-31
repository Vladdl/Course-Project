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
    public partial class AdministratorForm : Form
    {
        public AdministratorForm()
        {
            InitializeComponent();
            label1.Text = "Admin";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MainForm.administrator.LogOut();
            MainForm mainnForm = new MainForm();
            this.Hide();
            mainnForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteUserForm deleteUserForm = new DeleteUserForm();
            this.Hide();
            deleteUserForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdministratorVIewForm viewUserForm = new AdministratorVIewForm();
            this.Hide();
            viewUserForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeletePropertyForm deletePropertyForm = new DeletePropertyForm();
            this.Hide();
            deletePropertyForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PropertyForm propertyForm = new PropertyForm();
            this.Hide();
            propertyForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
