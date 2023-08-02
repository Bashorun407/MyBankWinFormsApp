using MyBankApp.Core.ServiceManager.Abstractions;

namespace MyBankWinFormsApp
{
    public partial class Form1 : Form
    {
        private IServiceManager serviceManager;
        public Form1(IServiceManager service)
        {
            serviceManager = service;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String text = emailTextBox.Text;
            MessageBox.Show("You typed: " + text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Register_Submit_Click(object sender, EventArgs e)
        {
            string text = emailTextBox.Text;
            string password = PasswordTextBox.Text;
            var result = serviceManager.UserService.Login(text, password);
            MessageBox.Show($" Successfully logged in:{result.ToString}");
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}