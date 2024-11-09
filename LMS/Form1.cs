using System;
using System.Data.SqlClient; //this will fetch all the necessary programs and packages for your project along with the source code
using System.Collections.Generic;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string dbConnectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING") ?? "";
            con = new SqlConnection(dbConnectionString);
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        private String getUserName()
        {
            con.Open();
            String syntax = "SELECT Value FROM systemTable where Property = 'UserName'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            dr.Close();
            con.Close();
            return temp;
        }

        private String getPassword()
        {
            con.Open();
            String syntax = "SELECT Value FROM systemTable where Property = 'Password'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            dr.Close();
            con.Close();
            return temp;
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
            String Uname = getUserName(), Upass = getPassword(), name, pass;
            name = textBox2.Text;
            pass = textBox1.Text;
            if (name.Equals(Uname) && pass.Equals(Upass))
            {
                // login
                label4.Enabled = false;
                MessageBox.Show("Logged in Successfully");
            }
            else
            {
                label4.Enabled = true;
                MessageBox.Show("Couldnt Login");
            }
        }
    }
}
