using Course;
using Course.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course
{
    public partial class LoginForm : Form
    {
        private string path = "RegistredUsers.json";
        public LoginForm()
        {
            InitializeComponent();
        }
      



        private void button2_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            RegistredUserRepos.ReadTheUsers(path);
            RegistredUserRepos repos = new RegistredUserRepos();
            RegistredUser? existingUser = repos.GetRegistredUserByUsername(textBoxLogin.Text);
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            if (login == "admin" && password == "123")//Править
            {
                AdministratorForm administratorForm = new AdministratorForm();
                administratorForm.Show();
                this.Hide();
                return;
            }

            if  (string.IsNullOrWhiteSpace(textBoxLogin.Text) || textBoxLogin.Text != existingUser?.Login)
            {


                MessageBox.Show("Користувача з такою email адресою не існує", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxLogin.Text = "";
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxPassword.Text) || textBoxPassword.Text != existingUser?.Password)
            {

                MessageBox.Show("Невірний пароль", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Text = "";
                return;
            }

            MainForm.registredUser = Course.MainForm.guest.LogIn(login, password);
         
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";

            RegistredUserForm mainForm = new RegistredUserForm();
            mainForm.Show();
            this.Hide();

        }
    }
}

          

    

