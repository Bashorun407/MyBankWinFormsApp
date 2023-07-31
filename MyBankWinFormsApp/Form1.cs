namespace MyBankWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String text = textBox1.Text;
            MessageBox.Show("You typed: " + text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}