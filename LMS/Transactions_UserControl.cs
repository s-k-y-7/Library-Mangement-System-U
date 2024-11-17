using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class Transactions_UserControl : UserControl
    {
        private static Transactions_UserControl _instance;

        public static Transactions_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Transactions_UserControl();
                }
                return _instance;
            }
        }
        public Transactions_UserControl()
        {
            InitializeComponent();
            con = new SqlConnection(dbConnectionString);
        }
        public string Book1, Book2, Borrower;
        string dbConnectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING") ?? "";
        SqlConnection con;
        public SqlCommand cmd;
        public SqlDataReader dr;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SearchBorrowersButton_Click(object sender, EventArgs e)
        {
            con.Open();
            String syntax = "SELECT Book1 FROM Borrowers where brId =' " + BorrowersTextBox.Text + "'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();

            Book1_label.Text = Book1 = dr[0].ToString();
            con.Close();

            con.Open();
            syntax = "SELECT Book2 FROM Borrowers where brId =' " + BorrowersTextBox.Text + "'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            Book2_label.Text = Book2 = dr[0].ToString();
            con.Close();
        }

        private void SearchBookButton_Click(object sender, EventArgs e)
        {
            con.Open();
            String syntax = "SELECT borrower FROM books where accNo =' " + AccNoTextBox.Text + "'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            borrowedBy_label.Text = Borrower = dr[0].ToString();
            con.Close();
        }

        private void IssueBookButton_Click(object sender, EventArgs e)
        {
            SearchBookButton.PerformClick();
            if (Borrower != "")
            {
                MessageBox.Show("Book s already borrowed by " + Borrower);
                return;
            }

            SearchBorrowersButton.PerformClick();
            if ((Book1 != "") && (Book2 != ""))
            {
                MessageBox.Show("Borrower has already borrowed 2 books");
                return;
            }

            try
            {
                if (Book1 == "")
                {
                    cmd = new SqlCommand("Transact_Update_Book1_SP", con);
                }
                else
                {
                    cmd = new SqlCommand("Transact_Update_Book2_SP", con);
                }
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@brId", BorrowersTextBox.Text);
                cmd.Parameters.AddWithValue("@accNo", AccNoTextBox.Text);

                con.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            cmd = new SqlCommand("Transact_Update_Borrower_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@accNo", AccNoTextBox.Text);
            cmd.Parameters.AddWithValue("@brId", BorrowersTextBox.Text);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            SearchBookButton.PerformClick();
            SearchBorrowersButton.PerformClick();
            MessageBox.Show("Book Issued Successfully");
        }

        private void ReturnBookButton_Click(object sender, EventArgs e)
        {
            SearchBookButton.PerformClick();
            SearchBorrowersButton.PerformClick();
            if ((AccNoTextBox.Text == Book1) && (AccNoTextBox.Text == Book2))
            {
                MessageBox.Show("The borrower has not borrowed the book");
                return;
            }

            

            try
            {
                if (Book1 == AccNoTextBox.Text)
                {
                    cmd = new SqlCommand("Transact_Update_Book1_SP", con);
                }
                else
                {
                    cmd = new SqlCommand("Transact_Update_Book2_SP", con);
                }
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@brId", BorrowersTextBox.Text);
                cmd.Parameters.AddWithValue("@accNo", (object)DBNull.Value);

                con.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            cmd = new SqlCommand("Transact_Update_Borrower_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@brId", (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@accNo", AccNoTextBox.Text );

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            SearchBookButton.PerformClick();
            SearchBorrowersButton.PerformClick();
            MessageBox.Show("Book Returned Successfully");
        }
    }
}
