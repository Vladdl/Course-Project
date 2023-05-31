using Course.Classes;

namespace Course
{
    public partial class MainForm : Form
    {
        public static Guest guest = null;
        public static RegistredUser registredUser = null;
        public static Administrator administrator = null;
        public MainForm()
        {
            InitializeComponent();
            guest = new Guest();
        }


        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            RegistrationForm registration = new RegistrationForm();
            this.Hide();
            registration.Show();
        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

        private void buttonViewProperies_Click(object sender, EventArgs e)
        {

            ViewPropertyForGuestForm viewProperty = new ViewPropertyForGuestForm();
            this.Hide();
            viewProperty.Show();
        }
    }
}