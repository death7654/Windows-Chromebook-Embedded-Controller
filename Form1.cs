namespace EC_Controller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            userControl11.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void Fan_Click(object sender, EventArgs e)
        {
            userControl11.Show();
            userControl11.BringToFront();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}