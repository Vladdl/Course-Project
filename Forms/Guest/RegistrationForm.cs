using Course.Classes;
using Microsoft.VisualBasic.Logging;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Course
{
    public partial class RegistrationForm : Form
    {
        private string path = "RegistredUsers.json";
        public RegistrationForm()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {

            RegistredUserRepos.ReadTheUsers(path);
            RegistredUserRepos repos = new RegistredUserRepos();
            if (string.IsNullOrWhiteSpace(textBoxName.Text) || textBoxName.TextLength < 2 || textBoxName.TextLength > 20 || textBoxName.Text.Any(char.IsDigit))
            {

                MessageBox.Show("Некоректно введене ім'я", "Помилка!", MessageBoxButtons.
                 OK, MessageBoxIcon.Information);
                textBoxName.Text = "";
                return;
            }


            if (string.IsNullOrWhiteSpace(textBoxSurname.Text) || textBoxSurname.TextLength < 2 || textBoxSurname.TextLength > 20 || textBoxSurname.Text.Any(char.IsDigit))
            {

                MessageBox.Show("Некоректно введене прізвище", "Помилка!", MessageBoxButtons.
                 OK, MessageBoxIcon.Information);
                textBoxSurname.Text = "";
                return;

            }
            RegistredUser? existingUser = repos.GetRegistredUserByUsername(textBoxLogin.Text);
            if (string.IsNullOrWhiteSpace(textBoxLogin.Text) || !Regex.IsMatch(textBoxLogin.Text, @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$")|| textBoxLogin.TextLength>20)
            {

                MessageBox.Show("Некоректний формат email адреси", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxLogin.Text = "";
                return;
            }
            else if (existingUser != null)
            {
                MessageBox.Show("Користувач з такою email адресою вже існує", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxLogin.Text = "";
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxPassword.Text) || textBoxPassword.TextLength < 5 || textBoxPassword.TextLength > 10)
            {
                MessageBox.Show("Некоректно введений пароль", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxPassword.Text = "";
                return;
            }


            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            MainForm.registredUser = MainForm.guest.Registration(name, surname, login, password);
            MessageBox.Show("Вітаємо, ви успішно зареєструвались на сайті Booking.com", "Повідомлення!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxName.Text = "";
            textBoxSurname.Text = "";
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
            // Вывод сообщения об успешной регистрации пользователя


            MainForm mainForm = new MainForm();
            RegistredUserRepos.SavingTheUsers(path);
            this.Hide();
            mainForm.Show();
        }
    }
}
