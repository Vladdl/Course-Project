using Course.Classes;
using System;
using System.Collections;
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
    public partial class ViewPropertyForGuestForm : Form
    {
        private string path = "Property.json";
        public ViewPropertyForGuestForm()
        {
            PropertyRepos.ReadTheProperty(path);
            InitializeComponent();
            dataGridView1.DataSource = MainForm.guest.ViewProperties();

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
        }
    }
}
