namespace LMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Uname = "1", Upass = "1", name, pass;
            name = textBox1.Text;
            pass = textBox2.Text;

            if (name.Equals(Uname) && pass.Equals(Upass))
            {
                // login
                label4.Enabled = false;
                MessageBox.Show("Logged in Successfully");
            }
            else
            {
                label4.Enabled = true;
            }
        }
    }
}
