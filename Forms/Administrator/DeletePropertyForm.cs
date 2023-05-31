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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Course
{
    public partial class DeletePropertyForm : Form
    {
        private string path = "Property.json";
        private string path2 = "Booking.json";
        Administrator administrator = new Administrator();
        DialogResult result;
        public DeletePropertyForm()
        {
            BookingRepos.ReadTheBooking(path2);
            PropertyRepos.ReadTheProperty(path);
            InitializeComponent();
            dataGridView1.DataSource = administrator.ViewProperties();
            administrator._Message += Message;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            BookingRepos bookingRepos = new BookingRepos();
            for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView1.Rows[i];

                if (row.Cells["Column1"] is DataGridViewCheckBoxCell checkBoxCell &&
                    checkBoxCell.Value is bool isChecked && isChecked)
                {
                    if (row.Cells["idDataGridViewTextBoxColumn"].Value is int userId && row.Cells["nameDataGridViewTextBoxColumn"].Value is string propertyName)
                    {

                        var bookings = BookingRepos.GetAllBookings().Where(b => b.Property == propertyName).ToList();


                        if (bookings.Count > 0)
                        {
                           
                            Property propertyToDelete = administrator.ViewProperties().FirstOrDefault(p => p.Id == userId);
                            administrator.Messages(propertyToDelete);

                            if (result == DialogResult.OK)
                            {
                               

                                administrator.DeleteProperty(userId);

                                foreach (var booking in bookings)
                                {
                                    bookingRepos.RemoveBooking(booking);
                                }
                            }
                        }
                        else
                        {
                            

                            administrator.DeleteProperty(userId);
                        }
                      
                        dataGridView1.DataSource = null;
                        PropertyRepos.SavingTheProperty(path);
                        BookingRepos.SavingTheBooking(path2);
                        dataGridView1.DataSource = administrator.ViewProperties();
                    

                        


                    }
                }
            }


        }
        public void Message(Property property)
        {
            result = MessageBox.Show("Ви видаляєте житло, яке було заброньоване!", "Увага!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            AdministratorForm administratorForm = new AdministratorForm();
            this.Hide();
            administratorForm.Show();
        }
    }
}
